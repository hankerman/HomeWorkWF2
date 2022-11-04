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
    public partial class Task2 : Form
    {
        int count, res;
        bool finish;
        public Task2()
        {
            InitializeComponent();
            count = 0;
            finish = false;
        }

        private void startPlayer_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            finish = false;
            int a = 1;
            int b = 2000;
            
            while (!finish)
            {
                res = random.Next(a,b);
                DialogResult result = MessageBox.Show(res.ToString(), $"попытка {++count}", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show($"Победа, колличество попыток {count}", "Победа");
                    finish = true;
                }
                else
                {
                    if(res == numericUpDown1.Value)
                    {
                        MessageBox.Show($"Обманщик, я победил и мне потребовалось {count} попыток", "Обман");
                        finish = true;
                    }
                    else
                    {
                        DialogResult resul = MessageBox.Show($"Больше?", "", MessageBoxButtons.YesNo);
                        if(resul == DialogResult.Yes)
                        {
                            a = res;
                        }
                        else
                        {
                            b = res;
                        }
                    }
                    
                }
            }

        }

        private void startComp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            finish = false;
            
            while (!finish)
            {
                res = random.Next(1, 2000);
                if(res == numericUpDown1.Value)
                {
                    MessageBox.Show($"Победа, {count} попыток", "Победа");
                    finish= true;
                }
                else
                {
                    count++;
                    
                }
            }
        }
    }
}
