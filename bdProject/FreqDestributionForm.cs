using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace bdProject
{
    public partial class FreqDestributionForm : Form
    {
        DataTable dt;

        public FreqDestributionForm(DataSet dataSet)
        {
            InitializeComponent();
            destributionTable.DataSource = dataSet.Tables[0].DefaultView;
            dt = dataSet.Tables[0];
            for (int i = 0; i < destributionTable.RowCount; i += 2)
            {
                destributionTable.Rows[i].DefaultCellStyle.BackColor = SystemColors.InactiveBorder;
            }
            destributionTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            destributionTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EvenDestrCheckBox.Checked = true;
            UnevenDestrCheckBox.Checked = true;
            partTextBox.Text = "100";
        }

        private void FreqDestributionForm_Resize(object sender, EventArgs e)
        {
         //   destributionTable.Width = 
        }

        private void UnevenDestrCheckBox_Click(object sender, EventArgs e)
        {
            if (!EvenDestrCheckBox.Checked)
                UnevenDestrCheckBox.Checked = true;
        }

        private void EvenDestrCheckBox_Click(object sender, EventArgs e)
        {
            if (!UnevenDestrCheckBox.Checked)
                EvenDestrCheckBox.Checked = true;
        }

        private void changeDestrType()
        {
            // DataTable table = (DataTable)(destributionTable.DataSource);
            DataTable table = new DataTable();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                DataColumn column = new DataColumn(dt.Columns[i].ColumnName);
                column.DataType = dt.Columns[i].DataType;
                table.Columns.Add(column);
            }
   //         table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                double d1 = Convert.ToDouble(row["минимФрагмент"]);
                double D1 = Convert.ToDouble(row["максФрагмент"]);
                if ((D1 / d1 < 10 && EvenDestrCheckBox.Checked) || (D1 / d1 >= 10 && UnevenDestrCheckBox.Checked))
                {
                    DataRow dsRow = table.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)                    
                        dsRow[i] = row[i];
                    table.Rows.Add(dsRow);
                }
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            destributionTable.DataSource = ds.Tables[0].DefaultView;
        }

        private void ChangeDestrTypeButton_Click(object sender, EventArgs e)
        {
            changeDestrType();
        }

        private void findPeaksButton_Click(object sender, EventArgs e)
        {
            //GraphPane pane = new GraphPane(new RectangleF(1, 1, 300, 300), "", "Предложения", "Частота встречаемости");
            //PointPairList list = new PointPairList();
            //double xmin = -1;
            //double xmax = 1;

            //// Заполняем список точек
            //for (double x = xmin; x <= xmax; x++)
            //{
            //    // добавим в список точку
            //    list.Add(x, x);
            //}

            //// Создадим кривую с названием "Sinc", 
            //// которая будет рисоваться голубым цветом (Color.Blue),
            //// Опорные точки выделяться не будут (SymbolType.None)
            //LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

            //// Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            //// В противном случае на рисунке будет показана только часть графика, 
            //// которая умещается в интервалы по осям, установленные по умолчанию
            //Z.AxisChange();

            //// Обновляем график
            //zedGraph.Invalidate();
            int percent = Convert.ToInt32(partTextBox.Text);
            double part = (double)percent / 100;
        //    Dictionary<string, int[]> wordsFreqs = new Dictionary<string, int[]>();
            GraphForm form = new GraphForm();
            for (int j = 0; j < destributionTable.RowCount * part; j++)
            {
                Parameters param = new Parameters();
                param.word = destributionTable.Rows[j].Cells[0].Value.ToString();
                GetSentForSelectedWord sentFreq = new GetSentForSelectedWord(MainForm.BDLocation, MainForm.tableName, param);
                int[] frqMas = sentFreq.GetFreqDestribution(sentFreq, MainForm.sentCount, 10);
                //        wordsFreqs.Add(param.word, frqMas);
                form.drawGraph(param.word, frqMas);
                break;
            }
            form.Show();
            //foreach (KeyValuePair<string, int[]> pair in wordsFreqs)
            //{
            //    form.drawGraph(pair.Key, pair.Value);
            //    break;
            //}


        }

        private void findPeak()
        {
            int percent = Convert.ToInt32(partTextBox.Text);
            double part = (double)percent / 100;
            Dictionary<string, int> peaks = new Dictionary<string, int>();
            DataTable peaksDestr = new DataTable();
            peaksDestr.Columns.Add(new DataColumn("НормФорма"));
            peaksDestr.Columns["НормФорма"].DataType = typeof(string);
            peaksDestr.Columns.Add(new DataColumn("ПредложенияПика"));
            peaksDestr.Columns["ПредложенияПика"].DataType = typeof(string);
            for (int i = 0; i < destributionTable.RowCount * part; i++)
            {
                Parameters param = new Parameters();
                param.word = destributionTable.Rows[i].Cells[0].Value.ToString();
                GetSentForSelectedWord sentFreq = new GetSentForSelectedWord(MainForm.BDLocation, MainForm.tableName, param);
                int partition = MainForm.sentCount / 10;
                int[] frqMas = sentFreq.GetFreqDestribution(sentFreq, MainForm.sentCount, partition);
                int maxIndex = peaks[param.word] = Array.IndexOf(frqMas, frqMas.Max());
                DataRow row = peaksDestr.NewRow();
                row["НормФорма"] = param.word;
                row["ПредложенияПика"] = (maxIndex * 10).ToString() + "-" + ((maxIndex + 1) * 10).ToString();
                peaksDestr.Rows.Add(row);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(peaksDestr);
            TerminSurroundingsForm form = new TerminSurroundingsForm(ds);
            form.Show();
        }
    }
}
