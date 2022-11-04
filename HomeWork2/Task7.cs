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
    public partial class Task7 : Form
    {
        DateTime date1;
        int year, month, day, hour, minute;

        public Task7()
        {
            InitializeComponent();
            date1 = DateTime.Now;
            numericUpDownYearl.Minimum = date1.Year;
            numericUpDownMount.Minimum = date1.Month;
            numericUpDownDay.Minimum = date1.Day;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date = new DateTime((int)numericUpDownYearl.Value, (int)numericUpDownMount.Value, (int)numericUpDownDay.Value,
                (int)numericUpDown1.Value, (int)numericUpDown2.Value, 0);
            
            year = date.Year - date1.Year;
            month = date.Month - date1.Month ;
            day = date.Day - date1.Day;
            hour = date.Hour - date1.Hour;
            minute = date.Minute - date1.Minute;            

            labelDate.Text = $"Осталось {year} лет {month} месяцев {day} дней";
            labelTimes.Text = $"{hour} часов {minute} минут";
            this.Text = date1.ToString();


        }
        
    }
}
