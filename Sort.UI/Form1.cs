using Sort.Bl;
using System;
using System.Collections.Generic;
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
            label3.Text = "";
            var bubleSort = new BubleSort<int>();
            bubleSort.Items.AddRange(Items);
            var time = bubleSort.Sort();
            foreach (var item in bubleSort.Items)
            {
                label3.Text += " " + item;
            }
        }

        private void CoctailSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var cocktailSort = new CocktailSort<int>();
            cocktailSort.Items.AddRange(Items);
            var time = cocktailSort.Sort();
            foreach (var item in cocktailSort.Items)
            {
                label3.Text += " " + item;
            }
        }

        private void InsertionSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var insertionSort = new InsertionSort<int>();
            insertionSort.Items.AddRange(Items);
            var time = insertionSort.Sort();
            foreach (var item in insertionSort.Items)
            {
                label3.Text += " " + item;
            }
        }

        private void ShellSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var insertionSort = new InsertionSort<int>();
            insertionSort.Items.AddRange(Items);
            var time = insertionSort.Sort();
            foreach (var item in insertionSort.Items)
            {
                label3.Text += " " + item;
            }
        }

        private void quickSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var QuickSort = new QuickSort<int>();
            QuickSort.Items.AddRange(Items);
            var time = QuickSort.Sort();
            foreach (var item in QuickSort.Items)
            {
                label3.Text += " " + item;
            }
        }

        private void MergeSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var MergeSort = new MergeSort<int>();
            MergeSort.Items.AddRange(Items);
            MergeSort.Sort();
            foreach (var item in MergeSort.Items)
            {
                label3.Text += " " + item;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var SelectionSort = new SelectionSort<int>();
            SelectionSort.Items.AddRange(Items);
            SelectionSort.Sort();
            foreach (var item in SelectionSort.Items)
            {
                label3.Text += " " + item;
            }
        }
    }
}
