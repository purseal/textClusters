using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace bdProject
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// BDLocation - absolute name of database
        /// tableName - table name of morphological and syntactic characteristics
        /// paramPartOfSpeech - part of speech in filtering or of the selected word
        /// termSurPartOfSpeech - part of speech of terminological surroundings
        /// paramSentNumber - sentence number of selected word or in filtering
        /// radius - maximum words count between selected word and term
        /// </summary>
        string BDLocation;
        string tableName;
        string paramPartOfSpeech;
        string termSurPartOfSpeech;
        string paramSentNumber;
        DataSet dataSet;
        public static DataSet ds;

        public MainForm()
        {
            InitializeComponent();
            radioButtonNoun.Enabled = false;
            radioButtonAdj.Enabled = false;
            radioButtonAdv.Enabled = false;
            radioButtonParticiple.Enabled = false;
            radioButtonVerb.Enabled = false;
            textBoxSentNumber.Enabled = false;
            //        textBoxBDLocation.Text = "C:\\Users\\Мария\\Documents\\MEPHI\\7 семестр\\нир\\Бд.accdb";
            //        textBoxTableName.Text = "1";

            //      dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonChooseBDLocation_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BDLocation = openFileDialog1.FileName;
                textBoxBDLocation.Text = BDLocation;
            }
        }

        int sentCount;

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            BDLocation = textBoxBDLocation.Text;
            tableName = textBoxTableName.Text;
            Parameters param = new Parameters();
            paramSentNumber = textBoxSentNumber.Text;
            param.PartOfSpeech = paramPartOfSpeech;
            param.sentNumber = paramSentNumber;
            try
            {
                LoadFullTable bdConnect = new LoadFullTable(BDLocation, tableName, param);
                dataGridView1.DataSource = bdConnect.dataSet.Tables[0].DefaultView;
                ds = bdConnect.dataSet;
                dataGridView1.Columns[0].Width = 600;
                Connect ts = new Connect(BDLocation, tableName);
                ts.SendCommand(ts.getSentCountCommand(tableName));
                sentCount = Convert.ToInt32(ts.dataSet.Tables[0].Rows[0][0].ToString());
            }
            catch (OleDbConnectionException ex)
            {
                MessageBox.Show(ex.message);
            }
            /*    catch(OleDbSendCommandException ex)
                {
                    MessageBox.Show(ex.message);
                }*/
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void radioButtonNoun_CheckedChanged(object sender, EventArgs e)
        {
            paramPartOfSpeech = "С";
        }

        private void radioButtonAdj_CheckedChanged(object sender, EventArgs e)
        {
            paramPartOfSpeech = "П";
        }

        private void radioButtonParticiple_CheckedChanged(object sender, EventArgs e)
        {
            paramPartOfSpeech = "ПРИЧАСТИЕ";
        }

        private void radioButtonVerb_CheckedChanged(object sender, EventArgs e)
        {
            paramPartOfSpeech = "Г";
        }

        private void radioButtonAdv_CheckedChanged(object sender, EventArgs e)
        {
            paramPartOfSpeech = "Н";
        }

        private void radioButtonNoun1_CheckedChanged(object sender, EventArgs e)
        {
            termSurPartOfSpeech = "С";
        }

        private void radioButtonAdj1_CheckedChanged(object sender, EventArgs e)
        {
            termSurPartOfSpeech = "П";
        }

        private void radioButtonParticiple1_CheckedChanged(object sender, EventArgs e)
        {
            termSurPartOfSpeech = "ПРИЧАСТИЕ";
        }

        private void radioButtonVerb1_CheckedChanged(object sender, EventArgs e)
        {
            termSurPartOfSpeech = "Г";
        }

        private void radioButtonAdv1_CheckedChanged(object sender, EventArgs e)
        {
            termSurPartOfSpeech = "Н";
        }

        private void checkBoxSentNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSentNumber.Checked)
                textBoxSentNumber.Enabled = true;
            else
            {
                textBoxSentNumber.Text = "";
                textBoxSentNumber.Enabled = false;
            }
        }

        private void checkBoxPartOfSpeech_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPartOfSpeech.Checked)
            {
                radioButtonNoun.Enabled = true;
                radioButtonAdj.Enabled = true;
                radioButtonAdv.Enabled = true;
                radioButtonParticiple.Enabled = true;
                radioButtonVerb.Enabled = true;
            }
            else
            {
                radioButtonNoun.Enabled = false;
                radioButtonAdj.Enabled = false;
                radioButtonAdv.Enabled = false;
                radioButtonParticiple.Enabled = false;
                radioButtonVerb.Enabled = false;
                paramPartOfSpeech = null;
            }
        }

        private string getTermPartOfSpeech()
        {
            if (radioButtonAdj1.Checked)
                return "П";
            if (radioButtonAdv1.Checked)
                return "Н";
            if (radioButtonNoun1.Checked)
                return "С";
            if (radioButtonParticiple1.Checked)
                return "ПРИЧАСТИЕ";
            if (radioButtonVerb1.Checked)
                return "Г";
            else
                return "";
        }
        public static string word;

        private void buttonShowTerms_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count != 1)
                goto end2;
            string curWord = dataGridView1.CurrentCell.Value.ToString();
            int rowNumber = dataGridView1.CurrentRow.Index;
            BDLocation = textBoxBDLocation.Text;
            tableName = textBoxTableName.Text;
            string radius = textBoxRadius.Text;
            if (radius == "")
                goto end1;
            Parameters param = new Parameters();
            param.word = curWord;
            param.termSurPartOfSpeech = getTermPartOfSpeech();
            param.radius = radius;
            try
            {
                LoadTerminSurroundings ts = new LoadTerminSurroundings(BDLocation, tableName, param);
                TerminSurroundingsForm form2 = new TerminSurroundingsForm(ts.dataSet);
                form2.ClientSize = new Size(form2.dataGridView1.Size.Width, form2.ClientSize.Height);
                form2.Show();
                if (dataGridView1.Columns.Count != 0)
                {
                    form2.dataGridView1.Columns[0].Width = 550;
                    form2.dataGridView1.Columns[1].Width = 200;
                }

            }
            catch (OleDbConnectionException ex)
            {
                MessageBox.Show(ex.message);
            }
            catch (OleDbSendCommandException ex)
            {
                MessageBox.Show(ex.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            goto goodEnd;
        end1: MessageBox.Show("Введите максималное количество слов \nдо выбранного слова");
        end2: MessageBox.Show("Выберите одно слово");
        goodEnd:;
        }

        static public void filter(DataSet dataSet)
        {
            var rows = dataSet.Tables[0].Select("НормФорма = '" + word + "'");
            if (rows.Length > 0)
                MessageBox.Show(rows[0][1].ToString());
        }

        private void showSentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 1)
                goto end2;
            string curWord = dataGridView1.CurrentCell.Value.ToString();
            //    int rowNumber = dataGridView1.CurrentRow.Index;
            //BDLocation = textBoxBDLocation.Text;
            //tableName = textBoxTableName.Text;
            Parameters param = new Parameters();
            param.word = curWord;
            int[] frqMas = new int[11];
            try
            {
                GetSentForSelectedWord sentDistr = new GetSentForSelectedWord(BDLocation, tableName, param);
                frqMas = sentDistr.GetFreqDestribution(sentDistr, sentCount);
                string output = "";
                for (int i = 0; i < 11; i++)
                    output += frqMas[i] + " ";
                TerminSurroundingsForm form2 = new TerminSurroundingsForm(sentDistr.dataSet);
                DataRowCollection rows = sentDistr.dataSet.Tables[0].Rows;
                //    int[] frqMas = new int[11];
                //    int k = 0;
                //    string output = "";
                //    for (int j = 0; j < rows.Count; j++)
                //    {
                //        while (Convert.ToInt32(rows[j][1]) > (k + 1) * (sentCount / 10))
                //        {
                //            output += frqMas[k] + " ";
                //            k++;
                //        }
                //        frqMas[k] += 1;
                //    }
                //    output += frqMas[k];
                form2.Text = rows.Count + " предложений из " + sentCount;
                form2.ClientSize = new Size(form2.dataGridView1.Size.Width, form2.ClientSize.Height);
                form2.Show();
                if (dataGridView1.Columns.Count != 0)
                {
                    form2.dataGridView1.Columns[0].Width = 550;
                    form2.dataGridView1.Columns[1].Width = 200;
                }
                MessageBox.Show("Распределение частоты:\n" + output);
            }
            catch (OleDbConnectionException ex)
            {
                MessageBox.Show(ex.message);
            }
            catch (OleDbSendCommandException ex)
            {
                MessageBox.Show(ex.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            goto goodEnd;
        end2: MessageBox.Show("Выберите одно слово");
        goodEnd:;
        }

        struct d1Statistic
        {
            public int d1, d1SentNumberBegin, d1SentNumberEnd, D1, D1SentNumberBegin, D1SentNumberEnd;

            public d1Statistic(int sentNumer)
            {
                d1 = sentNumer;
                d1SentNumberBegin = 0;
                d1SentNumberEnd = 0;
                D1 = 0;
                D1SentNumberBegin = 0;
                D1SentNumberEnd = 0;
            }
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            DataTable allStat = new DataTable();
            allStat.Columns.Add(new DataColumn("НормФорма"));
            allStat.Columns.Add(new DataColumn("минимФрагмент"));
            allStat.Columns["минимФрагмент"].DataType = typeof(int);
            allStat.Columns.Add(new DataColumn("минНачНомерПредл"));
            allStat.Columns["минНачНомерПредл"].DataType = typeof(double);
            allStat.Columns.Add(new DataColumn("минКонНомерПредл"));
            allStat.Columns["минКонНомерПредл"].DataType = typeof(double);
            allStat.Columns.Add(new DataColumn("максФрагмент"));
            allStat.Columns["максФрагмент"].DataType = typeof(int);
            allStat.Columns.Add(new DataColumn("максНачНомерПредл"));
            allStat.Columns["максНачНомерПредл"].DataType = typeof(double);
            allStat.Columns.Add(new DataColumn("максКонНомерПредл"));
            allStat.Columns["максКонНомерПредл"].DataType = typeof(double);
            try
            {
                DataRowCollection wordRow = ds.Tables[0].Rows;
                int n = Convert.ToInt32(nTextBox.Text);
                for (int j = 0; j < wordRow.Count; j++)
                {
                    Parameters param = new Parameters();
                    param.word = wordRow[j][0].ToString();
                    GetSentForSelectedWord ts = new GetSentForSelectedWord(BDLocation, tableName, param);
                    DataRowCollection sentRows = ts.dataSet.Tables[0].Rows;
                    d1Statistic stat = new d1Statistic(sentCount);
                    for (int i = 0; i < sentRows.Count - n; i++)
                    {
                        int dist = Convert.ToInt32(sentRows[i + n][1]) - Convert.ToInt32(sentRows[i][1]);
                        if (dist < stat.d1)
                        {
                            stat.d1 = dist;
                            stat.d1SentNumberBegin = Convert.ToInt32(sentRows[i][1]);
                            stat.d1SentNumberEnd = Convert.ToInt32(sentRows[i + n][1]);
                        }
                        if (dist > stat.D1)
                        {
                            stat.D1 = dist;
                            stat.D1SentNumberBegin = Convert.ToInt32(sentRows[i][1]);
                            stat.D1SentNumberEnd = Convert.ToInt32(sentRows[i + n][1]);
                        }
                    }
                    DataRow row = allStat.NewRow();
                    row["НормФорма"] = param.word;
                    row["минимФрагмент"] = stat.d1;
                    row["минНачНомерПредл"] = Math.Round((double)stat.d1SentNumberBegin / sentCount, 5);
                    row["минКонНомерПредл"] = Math.Round((double)stat.d1SentNumberEnd / sentCount, 5);
                    row["максФрагмент"] = stat.D1;
                    row["максНачНомерПредл"] = Math.Round((double)stat.D1SentNumberBegin / sentCount, 5);
                    row["максКонНомерПредл"] = Math.Round((double)stat.D1SentNumberEnd / sentCount, 5);
                    allStat.Rows.Add(row);
                }
                allStat.DefaultView.Sort = "минНачНомерПредл";
                allStat = allStat.DefaultView.ToTable();
                DataSet dst = new DataSet();
                dst.Tables.Add(allStat);
                TerminSurroundingsForm form2 = new TerminSurroundingsForm(dst);
                form2.dataGridView1.Columns["минимФрагмент"].DefaultCellStyle.BackColor = Color.LightGray;
                form2.dataGridView1.Columns["максФрагмент"].DefaultCellStyle.BackColor = Color.LightGray;
                form2.Text = "Статистики";
                form2.Show();
            }
            catch (OleDbConnectionException ex)
            {
                MessageBox.Show(ex.message);
            }
            catch (OleDbSendCommandException ex)
            {
                MessageBox.Show(ex.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AllFreqButton_Click(object sender, EventArgs e)
        {
            DataTable allFreq = new DataTable();
            allFreq.Columns.Add(new DataColumn("НормФорма"));
            allFreq.Columns["НормФорма"].DataType = typeof(string);
            int sentStep = sentCount / 10;
            for (int i = 0; i < 10; i++)
            {
                string sentInterval;
                if (i == 10)
                    sentInterval = Convert.ToString(i * sentStep) + "-" + Convert.ToString(sentCount);
                else
                    sentInterval = Convert.ToString(i * sentStep) + "-" + Convert.ToString(sentCount);
                allFreq.Columns.Add(new DataColumn(sentInterval));
                allFreq.Columns[sentInterval].DataType = typeof(string);
            }            
            List<int[]> wordsDistrList = new List<int[]>();
            //try
            //{
                DataRowCollection wordRows = ds.Tables[0].Rows;
                for (int j = 0; j < wordRows.Count; j++)
                {
                    Parameters param = new Parameters();
                    param.word = wordRows[j][0].ToString();
                    GetSentForSelectedWord sentFreq = new GetSentForSelectedWord(BDLocation, tableName, param);
                    int[] frqMas = sentFreq.GetFreqDestribution(sentFreq, sentCount);
                    wordsDistrList.Add(frqMas);
                    DataRow row = allFreq.NewRow();
                    row["НормФорма"] = param.word;
                    for (int i = 0; i < 10; i++)
                    {
                        string sentInterval;
                        if (i == 10)
                            sentInterval = Convert.ToString(i * sentStep) + "-" + Convert.ToString(sentCount);
                        else
                            sentInterval = Convert.ToString(i * sentStep) + "-" + Convert.ToString(sentCount);
                        row[sentInterval] = frqMas[i];
                    }
                    allFreq.Rows.Add(row);
                }
                DataSet dst = new DataSet();
                dst.Tables.Add(allFreq);
                TerminSurroundingsForm form2 = new TerminSurroundingsForm(dst);
                form2.Text = "Распределения частот";
                form2.Show();
            //}
            //catch (OleDbConnectionException ex)
            //{
            //    MessageBox.Show(ex.message);
            //}
            //catch (OleDbSendCommandException ex)
            //{
            //    MessageBox.Show(ex.message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
