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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime((int)numericUpDownYearl.Value, (int)numericUpDownMount.Value, (int)numericUpDownDay.Value);

            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                LableDay.Text = "Ввоскресенье";
            }
            else if (date.DayOfWeek == DayOfWeek.Monday)
            {
                LableDay.Text = "Понедельник";
            }
            else if (date.DayOfWeek == DayOfWeek.Tuesday)
            {
                LableDay.Text = "Вторник";
            }
            else if (date.DayOfWeek == DayOfWeek.Wednesday)
            {
                LableDay.Text = "Среда";
            }
            else if (date.DayOfWeek == DayOfWeek.Thursday)
            {
                LableDay.Text = "Четверг";
            }
            else if (date.DayOfWeek == DayOfWeek.Friday)
            {
                LableDay.Text = "Пятница";
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                LableDay.Text = "Суббота";
            }

        }
    }
}
