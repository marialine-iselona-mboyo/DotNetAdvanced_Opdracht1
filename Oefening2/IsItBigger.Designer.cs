﻿namespace Oefening2
{
    partial class IsItBigger
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(291, 49);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(197, 101);
            this.btnTwo.TabIndex = 0;
            this.btnTwo.Text = "Click";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // IsItBigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTwo);
            this.Name = "IsItBigger";
            this.Text = "IsItBigger";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTwo;
    }
}