﻿namespace HomeWork2
{
    partial class Task5
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
            this.Static = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Static
            // 
            this.Static.Location = new System.Drawing.Point(288, 164);
            this.Static.Name = "Static";
            this.Static.Size = new System.Drawing.Size(216, 115);
            this.Static.TabIndex = 0;
            this.Static.Text = "Static";
            this.Static.UseVisualStyleBackColor = true;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Static);
            this.Name = "Task5";
            this.Text = "Task5";            
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Static;
    }
}