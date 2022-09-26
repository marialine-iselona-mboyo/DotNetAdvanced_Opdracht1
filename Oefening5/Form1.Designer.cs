namespace Oefening5
{
    partial class CelsiusToFahrenheit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Celsius = new System.Windows.Forms.Label();
            this.fahrenheit = new System.Windows.Forms.Label();
            this.celsiusTB = new System.Windows.Forms.TextBox();
            this.fahrenheitTB = new System.Windows.Forms.TextBox();
            this.celsiusBtn = new System.Windows.Forms.Button();
            this.fahrenheitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fahrenheitBtn);
            this.panel1.Controls.Add(this.celsiusBtn);
            this.panel1.Controls.Add(this.fahrenheitTB);
            this.panel1.Controls.Add(this.celsiusTB);
            this.panel1.Controls.Add(this.fahrenheit);
            this.panel1.Controls.Add(this.Celsius);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 223);
            this.panel1.TabIndex = 0;
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(81, 55);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(66, 25);
            this.Celsius.TabIndex = 0;
            this.Celsius.Text = "Celsius";
            // 
            // fahrenheit
            // 
            this.fahrenheit.AutoSize = true;
            this.fahrenheit.Location = new System.Drawing.Point(259, 55);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(93, 25);
            this.fahrenheit.TabIndex = 1;
            this.fahrenheit.Text = "Fahrenheit";
            // 
            // celsiusTB
            // 
            this.celsiusTB.Location = new System.Drawing.Point(55, 83);
            this.celsiusTB.Name = "celsiusTB";
            this.celsiusTB.Size = new System.Drawing.Size(121, 31);
            this.celsiusTB.TabIndex = 1;
            // 
            // fahrenheitTB
            // 
            this.fahrenheitTB.Location = new System.Drawing.Point(244, 83);
            this.fahrenheitTB.Name = "fahrenheitTB";
            this.fahrenheitTB.Size = new System.Drawing.Size(121, 31);
            this.fahrenheitTB.TabIndex = 2;
            // 
            // celsiusBtn
            // 
            this.celsiusBtn.Location = new System.Drawing.Point(55, 152);
            this.celsiusBtn.Name = "celsiusBtn";
            this.celsiusBtn.Size = new System.Drawing.Size(121, 34);
            this.celsiusBtn.TabIndex = 3;
            this.celsiusBtn.Text = "C to F";
            this.celsiusBtn.UseVisualStyleBackColor = true;
            this.celsiusBtn.Click += new System.EventHandler(this.celsiusBtn_Click);
            // 
            // fahrenheitBtn
            // 
            this.fahrenheitBtn.Location = new System.Drawing.Point(244, 152);
            this.fahrenheitBtn.Name = "fahrenheitBtn";
            this.fahrenheitBtn.Size = new System.Drawing.Size(121, 34);
            this.fahrenheitBtn.TabIndex = 4;
            this.fahrenheitBtn.Text = "F to C";
            this.fahrenheitBtn.UseVisualStyleBackColor = true;
            this.fahrenheitBtn.Click += new System.EventHandler(this.fahrenheitBtn_Click);
            // 
            // CelsiusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 248);
            this.Controls.Add(this.panel1);
            this.Name = "CelsiusToFahrenheit";
            this.Text = "CelsiusToFahrenheit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button fahrenheitBtn;
        private Button celsiusBtn;
        private TextBox fahrenheitTB;
        private TextBox celsiusTB;
        private Label fahrenheit;
        private Label Celsius;
    }
}