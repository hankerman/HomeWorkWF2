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

        public Task8()
        {
            InitializeComponent();
        }

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
            textBoxL.Text = "0";
            textBoxL.Enabled = radioButtonL.Checked;
            textBoxS.Enabled = false;
            textBoxL.TextChanged += new EventHandler(UpdatePricePL);
        }

        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            textBoxS.Text = "0";
            textBoxS.Enabled = radioButtonS.Checked;
            textBoxL.Enabled = false;
        }

        public void UpdatePricePL(Object sender, EventArgs args)
        {
            double res = Convert.ToDouble(textBoxL.Text) + Convert.ToDouble(textBoxPrice.Text);
            labelPriseP.Text = res.ToString();
        }
        
    }
}
