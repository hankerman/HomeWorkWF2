namespace HomeWork2
{
    partial class Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2));
            this.label1 = new System.Windows.Forms.Label();
            this.startPlayer = new System.Windows.Forms.Button();
            this.startComp = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startPlayer
            // 
            this.startPlayer.Location = new System.Drawing.Point(42, 259);
            this.startPlayer.Name = "startPlayer";
            this.startPlayer.Size = new System.Drawing.Size(187, 30);
            this.startPlayer.TabIndex = 1;
            this.startPlayer.Text = "Играть с пользователем";
            this.startPlayer.UseVisualStyleBackColor = true;
            this.startPlayer.Click += new System.EventHandler(this.startPlayer_Click);
            // 
            // startComp
            // 
            this.startComp.Location = new System.Drawing.Point(477, 259);
            this.startComp.Name = "startComp";
            this.startComp.Size = new System.Drawing.Size(187, 30);
            this.startComp.TabIndex = 2;
            this.startComp.Text = "Играть с только компьютеру";
            this.startComp.UseVisualStyleBackColor = true;
            this.startComp.Click += new System.EventHandler(this.startComp_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(267, 189);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(167, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 426);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.startComp);
            this.Controls.Add(this.startPlayer);
            this.Controls.Add(this.label1);
            this.Name = "Task2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startPlayer;
        private System.Windows.Forms.Button startComp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}