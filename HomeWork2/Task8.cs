using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork2
{
    public partial class Task8 : Form
    {
        double resPrK = 0;
        public Task8()
        {
            InitializeComponent();
            comboBoxPetrol.SelectedIndex = 0;
            
        }

        // заправка
        private void comboBoxPetrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPetrol.Text == "Аи - 92")
            {
                textBoxPrice.Text = "50";
            }else if(comboBoxPetrol.Text == "Аи - 95")
            {
                textBoxPrice.Text = "60";
            }
            else if (comboBoxPetrol.Text == "Дт")
            {
                textBoxPrice.Text = "40";
            }
        }

        private void radioButtonL_CheckedChanged(object sender, EventArgs e)
        {
            
            numericUpDownL.Enabled = radioButtonL.Checked;
            numericUpDownS.Enabled = false;
            numericUpDownL.ValueChanged += new EventHandler(UpdatePricePL);

        }

        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownS.Enabled = radioButtonS.Checked;
            numericUpDownL.Enabled = false;
            numericUpDownS.ValueChanged += new EventHandler(UpdatePricePS);
        }

        public void UpdatePricePL(Object sender, EventArgs args)
        {
            double res = Convert.ToDouble(numericUpDownL) * Convert.ToDouble(textBoxPrice.Text);
            labelPriseP.Text = res.ToString();
        }
        public void UpdatePricePS(Object sender, EventArgs args)
        {
            double res = Convert.ToDouble(numericUpDownS);
            labelPriseP.Text = res.ToString();
        }
        //кафе
        private void checkBoxHot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHot.Checked)
            {
                numericUpDownHot.Enabled = true;
                numericUpDownHot.ValueChanged += new EventHandler(UpdatePriseK);
            }
            else
            {
                numericUpDownHot.Enabled = false;
                numericUpDownHot.Value = 0;
            }

        }

        private void checkBoxGamb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGamb.Checked)
            {
                numericUpDownGamb.Enabled = true;
                numericUpDownGamb.ValueChanged += new EventHandler(UpdatePriseK);
            }
            else
            {
                numericUpDownGamb.Enabled = false;
                numericUpDownGamb.Value = 0;
            }
        }

        private void checkBoxFree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFree.Checked)
            {
                numericUpDownFree.Enabled = true;
                numericUpDownFree.ValueChanged += new EventHandler(UpdatePriseK);
            }
            else
            {
                numericUpDownFree.Enabled = false;
                numericUpDownFree.Value = 0;
            }
        }

        private void checkBoxCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCoffee.Checked)
            {
                numericUpDownCoffee.Enabled = true;
                numericUpDownCoffee.ValueChanged += new EventHandler(UpdatePriseK);
            }
            else
            {
                numericUpDownCoffee.Enabled = false;
                numericUpDownCoffee.Value = 0;
            }
        }

        private void UpdatePriseK(Object sender, EventArgs e)
        {
            
            resPrK = Convert.ToDouble(numericUpDownHot.Value) * Convert.ToDouble(textBoxPriseHot.Text) + 
                Convert.ToDouble(numericUpDownGamb.Value) * Convert.ToDouble(textBoxPriseGamb.Text) + 
                Convert.ToDouble(numericUpDownFree.Value) * Convert.ToDouble(textBoxPriseFree.Text) +
                Convert.ToDouble(numericUpDownCoffee.Value) * Convert.ToDouble(textBoxPriseCoffee.Text);

            labelPriseK.Text = resPrK.ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            labelPrise.Text = (Convert.ToDouble(labelPriseP.Text) + Convert.ToDouble(labelPriseK.Text)).ToString();
        }
    }
}
