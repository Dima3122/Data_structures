using Sort.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    Items.Add(rnd.Next(0, 100));
                }
            }
            feel_textBox.Text = "";
        }
        private void Start_BubleSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var bubleSort = new BubleSort<int>();
            bubleSort.Items.AddRange(Items);
            bubleSort.Sort();
            bubleSort.AlgorithmComplited += AlgorithmComplited;
        }

        private void AlgorithmComplited(object sender, EventArgs e)
        {
            var res = sender as AlgorithmBase<int>;
            print_result(res);
        }

        private void print_result(AlgorithmBase<int> res)
        {
            foreach (var item in res.Items.Take(52).ToArray())
            {
                label3.Text += " " + item;
            }
            label4.Text = "Время: " + res.timer.Elapsed.TotalMilliseconds + "MC.";
            label5.Text = "Количество обменов:" + res.SwopCount;
            label6.Text = "Количество сравнений:" + res.СompareCount;
        }
        
        private void CoctailSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var cocktailSort = new CocktailSort<int>();
            cocktailSort.Items.AddRange(Items);
            cocktailSort.Sort();
            cocktailSort.AlgorithmComplited += AlgorithmComplited;
        }
        private void InsertionSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var insertionSort = new InsertionSort<int>();
            insertionSort.Items.AddRange(Items);
            insertionSort.Sort();
            insertionSort.AlgorithmComplited += AlgorithmComplited;
        }
        private void ShellSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var ShellSort = new ShellSort<int>();
            ShellSort.Items.AddRange(Items);
            ShellSort.Sort();
            ShellSort.AlgorithmComplited += AlgorithmComplited;
        }
        private void quickSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var QuickSort = new QuickSort<int>();
            QuickSort.Items.AddRange(Items);
            QuickSort.Sort();
            QuickSort.AlgorithmComplited += AlgorithmComplited;
        }

        private void MergeSort_button_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var MergeSort = new MergeSort<int>();
            MergeSort.Items.AddRange(Items);
            MergeSort.Sort();
            MergeSort.AlgorithmComplited += AlgorithmComplited;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            var SelectionSort = new SelectionSort<int>();
            SelectionSort.Items.AddRange(Items);
            SelectionSort.Sort();
            SelectionSort.AlgorithmComplited += AlgorithmComplited;
        }
    }
}
