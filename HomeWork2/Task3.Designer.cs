namespace HomeWork2
{
    partial class Task3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task3));
            this.label1 = new System.Windows.Forms.Label();
            this.positionY = new System.Windows.Forms.Label();
            this.positionX = new System.Windows.Forms.Label();
            this.positionMouse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // positionY
            // 
            this.positionY.AutoSize = true;
            this.positionY.Location = new System.Drawing.Point(390, 380);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(13, 13);
            this.positionY.TabIndex = 6;
            this.positionY.Text = "0";
            // 
            // positionX
            // 
            this.positionX.AutoSize = true;
            this.positionX.Location = new System.Drawing.Point(390, 354);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(13, 13);
            this.positionX.TabIndex = 5;
            this.positionX.Text = "0";
            // 
            // positionMouse
            // 
            this.positionMouse.AutoSize = true;
            this.positionMouse.Location = new System.Drawing.Point(390, 323);
            this.positionMouse.Name = "positionMouse";
            this.positionMouse.Size = new System.Drawing.Size(13, 13);
            this.positionMouse.TabIndex = 4;
            this.positionMouse.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Положение мыши";
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.positionY);
            this.Controls.Add(this.positionX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label positionY;
        private System.Windows.Forms.Label positionX;
        private System.Windows.Forms.Label positionMouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}