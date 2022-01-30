using Sort.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort.UI
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algoritm = new BubleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                algoritm.Items.Add(value);
                label1.Text += " " + value;
            }
        }

        private void Sorting_buble_Click(object sender, EventArgs e)
        {
            algoritm.Sort();
            foreach (var item in algoritm.Items)
            {
                label2.Text += " " + item;
            }
        }
    }
}
