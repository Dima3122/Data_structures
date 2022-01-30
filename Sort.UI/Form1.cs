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
        List<int> Items = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Add_textBox.Text, out int value))
            {
                Items.Add(value);
            }
            Add_textBox.Text = "";
        }

        private void feel_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(feel_textBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    Items.Add(rnd.Next(0,100));
                }
            }
            feel_textBox.Text = "";
        }
        private void Start_BubleSort_button_Click(object sender, EventArgs e)
        {
            var bubleSort = new BubleSort<int>();
            bubleSort.Items.AddRange(Items);
            var time = bubleSort.Sort();
            foreach (var item in bubleSort.Items)
            {
                label3.Text += " " + item;
            }
        }
    }
}
