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
    public partial class FilterForm : Form
    {
        public string word;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.word = textBox1.Text;
            MainForm.filter(MainForm.ds);
            Close();;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
