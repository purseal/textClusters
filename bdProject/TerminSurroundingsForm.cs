using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdProject
{
    public partial class TerminSurroundingsForm : Form
    {
        public TerminSurroundingsForm(DataSet dataSet)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            int a = 0;
            for (int i = 0; i < dataGridView1.RowCount; i += 2)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.InactiveBorder;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ClientSize = new Size(dataGridView1.Size.Width, ClientSize.Height);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FilterForm form3 = new FilterForm();
                form3.Show();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Text == "Статистики")
                {
                    DataTable pairs = new DataTable();
                    pairs.Columns.Add(new DataColumn("НормФорма1"));
                    pairs.Columns.Add(new DataColumn("минимФрагмент1"));
                    pairs.Columns["минимФрагмент1"].DataType = typeof(int);
                    pairs.Columns.Add(new DataColumn("минНачНомерПредл1"));
                    pairs.Columns["минНачНомерПредл1"].DataType = typeof(double);
                    pairs.Columns.Add(new DataColumn("минКонНомерПредл1"));
                    pairs.Columns["минКонНомерПредл1"].DataType = typeof(double);
                    pairs.Columns.Add(new DataColumn("НормФорма2"));
                    pairs.Columns.Add(new DataColumn("минимФрагмент2"));
                    pairs.Columns["минимФрагмент2"].DataType = typeof(int);
                    pairs.Columns.Add(new DataColumn("минНачНомерПредл2"));
                    pairs.Columns["минНачНомерПредл2"].DataType = typeof(double);
                    pairs.Columns.Add(new DataColumn("минКонНомерПредл2"));
                    pairs.Columns["минКонНомерПредл2"].DataType = typeof(double);
                    //pairs.Columns.Add(new DataColumn("максФрагмент"));
                    //pairs.Columns["максФрагмент"].DataType = typeof(int);
                    //pairs.Columns.Add(new DataColumn("максНачНомерПредл"));
                    //pairs.Columns["максНачНомерПредл"].DataType = typeof(double);
                    //pairs.Columns.Add(new DataColumn("максКонНомерПредл"));
                    //pairs.Columns["максКонНомерПредл"].DataType = typeof(double);
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        double mainWordSentBegin = Convert.ToDouble(dataGridView1.Rows[i].Cells["минНачНомерПредл"].Value);
                        double mainWordSentEnd = Convert.ToDouble(dataGridView1.Rows[i].Cells["минКонНомерПредл"].Value);
                        int mainWordd1 = Convert.ToInt32(dataGridView1.Rows[i].Cells["минимФрагмент"].Value);
                        for (int j = i + 1; j < dataGridView1.RowCount - 1; j++)
                        {
                            double compairingWordSentBegin = Convert.ToDouble(dataGridView1.Rows[j].Cells["минНачНомерПредл"].Value);
                            double compairingWordSentEnd = Convert.ToDouble(dataGridView1.Rows[j].Cells["минКонНомерПредл"].Value);
                            int mainWordd2 = Convert.ToInt32(dataGridView1.Rows[j].Cells["минимФрагмент"].Value);
                            double a = mainWordd1 > mainWordd2 ? (double)(mainWordd2 + 1) / (mainWordd1 + 1) : (double)(mainWordd1 + 1) / (mainWordd2 + 1);
                            bool isOneWordInside = ((mainWordSentEnd >= compairingWordSentEnd && mainWordSentBegin <= compairingWordSentBegin) || 
                                (mainWordSentEnd <= compairingWordSentEnd && mainWordSentBegin >= compairingWordSentBegin)) && a > 0.5;
                            if (isOneWordInside)
                            {
                                DataRow row = pairs.NewRow();
                                row["НормФорма1"] = dataGridView1.Rows[i].Cells["НормФорма"].Value;
                                row["минимФрагмент1"] = dataGridView1.Rows[i].Cells["минимФрагмент"].Value;
                                row["минНачНомерПредл1"] = mainWordSentBegin;
                                row["минКонНомерПредл1"] = mainWordSentEnd;
                                row["НормФорма2"] = dataGridView1.Rows[j].Cells["НормФорма"].Value;
                                row["минимФрагмент2"] = dataGridView1.Rows[j].Cells["минимФрагмент"].Value;
                                row["минНачНомерПредл2"] = compairingWordSentBegin;
                                row["минКонНомерПредл2"] = compairingWordSentEnd;
                                pairs.Rows.Add(row);
                            }
                        }
                    }
                    pairs.DefaultView.Sort = "минимФрагмент1, минимФрагмент2";
                    pairs = pairs.DefaultView.ToTable();
                    DataSet dst = new DataSet();
                    dst.Tables.Add(pairs);
                    TerminSurroundingsForm form = new TerminSurroundingsForm(dst);
                    form.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    form.Text = "Вложенные пары";
                    form.Show();
                }
            }
        }

        private void TerminSurroundingsForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = ClientSize;
        }
    }
}
