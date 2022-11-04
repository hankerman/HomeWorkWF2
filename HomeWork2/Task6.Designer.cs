namespace HomeWork2
{
    partial class Task6
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
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYearl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LableDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearl)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(68, 180);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownDay.TabIndex = 0;
            // 
            // numericUpDownMount
            // 
            this.numericUpDownMount.Location = new System.Drawing.Point(164, 180);
            this.numericUpDownMount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMount.Name = "numericUpDownMount";
            this.numericUpDownMount.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownMount.TabIndex = 1;
            // 
            // numericUpDownYearl
            // 
            this.numericUpDownYearl.Location = new System.Drawing.Point(258, 180);
            this.numericUpDownYearl.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownYearl.Name = "numericUpDownYearl";
            this.numericUpDownYearl.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownYearl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "День";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(161, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Месяц";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(255, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Год";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LableDay
            // 
            this.LableDay.AutoSize = true;
            this.LableDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableDay.Location = new System.Drawing.Point(158, 63);
            this.LableDay.Name = "LableDay";
            this.LableDay.Size = new System.Drawing.Size(35, 31);
            this.LableDay.TabIndex = 9;
            this.LableDay.Text = "   ";
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 340);
            this.Controls.Add(this.LableDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownYearl);
            this.Controls.Add(this.numericUpDownMount);
            this.Controls.Add(this.numericUpDownDay);
            this.Name = "Task6";
            this.Text = "Task6";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.NumericUpDown numericUpDownMount;
        private System.Windows.Forms.NumericUpDown numericUpDownYearl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LableDay;
    }
}