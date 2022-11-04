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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(MouseMoving);
            this.MouseDown += new MouseEventHandler(MouseDownClic);
        }

        public void MouseMoving(Object sender, MouseEventArgs e)
        {
            positionX.Text = e.X.ToString();
            positionY.Text = e.Y.ToString();
            if(e.X < 10 || e.Y < 10 || e.X > this.Width - 30 || e.Y > this.Height - 50)
            {
                positionMouse.Text = "С наружи";
            }
            else if(e.X == 10 || e.Y == 10 || e.X == this.Width - 30 || e.Y == this.Height - 50)
            {
                positionMouse.Text = "На границе";
            }
            else
            {
                positionMouse.Text = "Внутри";
            }

        }

        public void MouseDownClic(Object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (e.X < 10 || e.Y < 10 || e.X > this.Width - 30 || e.Y > this.Height - 50)
                {
                    this.Text = "С наружи";
                }
                else if (e.X == 10 || e.Y == 10 || e.X == this.Width - 30 || e.Y == this.Height - 50)
                {
                    this.Text = "На границе";
                }
                else
                {
                    this.Text = "Внутри";
                }
            }else if(e.Button == MouseButtons.Right)
            {
                this.Text = e.Location.ToString();
            }

            

            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                this.Close();
            }

        }

    }
}
