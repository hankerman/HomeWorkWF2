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


    public partial class Task1 : Form
    {
        int symbol;
        string one = "Резюме";
        string two = "Сообщение 1";
        string three = "Сообщение 2";
        string four = "Сообщение 3";

        public Task1()
        {
            InitializeComponent();
            symbol = one.Length + two.Length + three.Length + four.Length;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MessageBox.Show(one);
            MessageBox.Show(two);
            MessageBox.Show(three);
            MessageBox.Show(four);
            MessageBox.Show($" количество символов в сообщениях {symbol}");
        }
    }
}
