using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.Show();
        }

        private void buttonTask6_Click(object sender, EventArgs e)
        {
            Task6 task6 = new Task6();
            task6.Show();
        }

        private void buttonTask7_Click(object sender, EventArgs e)
        {
            Task7 task7 = new Task7();
            task7.Show();
        }

        private void buttonTask8_Click(object sender, EventArgs e)
        {
            Task8 task8 = new Task8();
            task8.Show();
        }
    }
}
