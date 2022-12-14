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
    public partial class Task4 : Form
    {
        int count = 1;
        Point start;
        Point end;
        Point startMouse;
        Point endMouse;

        public Task4()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MouseDounPosision);
            this.MouseUp += new MouseEventHandler(MouseUpPosition);
            this.MouseMove += new MouseEventHandler(MousPosition);
        }

        public void MouseDounPosision(Object sender, MouseEventArgs e)
        {

            startMouse.X = e.X;
            startMouse.Y = e.Y;

        }

        public void MouseUpPosition(Object sender, MouseEventArgs e)
        {
            endMouse.X = e.X;
            endMouse.Y = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                CreateButton();
            }

        }

        public void CreateButton()
        {
            Abs();
            int X1 = end.X - start.X;
            int Y1 = end.Y - start.Y;


            if (X1 > 10 || Y1 > 10)
            {
                Button button = new Button();
                button.Location = start;
                button.Name = "button" + count.ToString();
                button.Size = new System.Drawing.Size(X1, Y1);
                button.TabIndex = count;
                button.Text = count.ToString();
                button.UseVisualStyleBackColor = true;
                this.Controls.Add(button);
                button.MouseDown += new MouseEventHandler(RemoveButton);
                button.MouseUp += new MouseEventHandler(StaticMove);



            }
            else
            {
                Button button = new Button();
                button.Location = start;
                button.Name = "button" + count.ToString();
                button.Size = new System.Drawing.Size(50, 50);
                button.TabIndex = 0;
                button.Text = count.ToString();
                button.UseVisualStyleBackColor = true;
                this.Controls.Add(button);
                button.MouseDown += new MouseEventHandler(RemoveButton);
                button.MouseUp += new MouseEventHandler(StaticMove);
            }
            count++;
        }

        public void Abs()
        {
            start.X = (startMouse.X < endMouse.X) ? startMouse.X : endMouse.X;
            start.Y = (startMouse.Y < endMouse.Y) ? startMouse.Y : endMouse.Y;
            end.X = (startMouse.X > endMouse.X) ? startMouse.X : endMouse.X;
            end.Y = (startMouse.Y > endMouse.Y) ? startMouse.Y : endMouse.Y;
        }

        public void RemoveButton(Object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Button button = (Button)sender;
                this.Controls.Remove(button);
                button.Dispose();
            }

        }


        public void StaticMove(Object sender, MouseEventArgs e)
        {
            Abs();
            int X1;
            int Y1;

            if (e.Button == MouseButtons.Left)
            {
                Random random = new Random();
                Button button = (Button)sender;
                X1 = button.Size.Width;
                Y1 = button.Size.Height;
                int n = random.Next(0, 2);
                if (n == 0)
                {
                    int X = random.Next(0, this.Width - X1);
                    int Y = random.Next(0, this.Height - Y1);
                    button.Location = new Point(X, Y);
                }
                else if (n == 1)
                {
                    int X = button.Location.X;
                    int Y = random.Next(0, this.Height - Y1);
                    button.Location = new Point(X, Y);
                }
                else
                {
                    int X = random.Next(0, this.Width - X1);
                    int Y = button.Location.Y;
                    button.Location = new Point(X, Y);
                }

            }

        }

        public void MousPosition(Object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();

        }

    }
}
