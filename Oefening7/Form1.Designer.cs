namespace Oefening7
{
    partial class sum
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbResult);
            this.panel1.Controls.Add(this.calculateBtn);
            this.panel1.Controls.Add(this.tbNumber);
            this.panel1.Controls.Add(this.number);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 209);
            this.panel1.TabIndex = 0;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(27, 152);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(321, 31);
            this.tbResult.TabIndex = 4;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(119, 91);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(112, 34);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(170, 28);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(150, 31);
            this.tbNumber.TabIndex = 2;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(71, 31);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(81, 25);
            this.number.TabIndex = 1;
            this.number.Text = "Number:";
            // 
            // sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 236);
            this.Controls.Add(this.panel1);
            this.Name = "sum";
            this.Text = "Sum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox tbResult;
        private Button calculateBtn;
        private TextBox tbNumber;
        private Label number;
    }
}