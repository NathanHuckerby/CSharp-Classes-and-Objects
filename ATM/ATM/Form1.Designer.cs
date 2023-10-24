namespace ATM
{
    partial class Form1
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
            this.lblPinNumber = new System.Windows.Forms.Label();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.lblWithdrawAmounts = new System.Windows.Forms.Label();
            this.lstWithdrawAmounts = new System.Windows.Forms.ListBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnEnterPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPinNumber
            // 
            this.lblPinNumber.AutoSize = true;
            this.lblPinNumber.Location = new System.Drawing.Point(323, 60);
            this.lblPinNumber.Name = "lblPinNumber";
            this.lblPinNumber.Size = new System.Drawing.Size(91, 13);
            this.lblPinNumber.TabIndex = 0;
            this.lblPinNumber.Text = "Enter PIN number";
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Location = new System.Drawing.Point(306, 101);
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.Size = new System.Drawing.Size(129, 20);
            this.txtPinNumber.TabIndex = 1;
            // 
            // lblWithdrawAmounts
            // 
            this.lblWithdrawAmounts.AutoSize = true;
            this.lblWithdrawAmounts.Location = new System.Drawing.Point(323, 177);
            this.lblWithdrawAmounts.Name = "lblWithdrawAmounts";
            this.lblWithdrawAmounts.Size = new System.Drawing.Size(95, 13);
            this.lblWithdrawAmounts.TabIndex = 2;
            this.lblWithdrawAmounts.Text = "Withdraw amounts";
            // 
            // lstWithdrawAmounts
            // 
            this.lstWithdrawAmounts.FormattingEnabled = true;
            this.lstWithdrawAmounts.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100",
            "200"});
            this.lstWithdrawAmounts.Location = new System.Drawing.Point(315, 223);
            this.lstWithdrawAmounts.Name = "lstWithdrawAmounts";
            this.lstWithdrawAmounts.Size = new System.Drawing.Size(120, 95);
            this.lstWithdrawAmounts.TabIndex = 3;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(306, 379);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(151, 23);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnEnterPin
            // 
            this.btnEnterPin.Location = new System.Drawing.Point(487, 98);
            this.btnEnterPin.Name = "btnEnterPin";
            this.btnEnterPin.Size = new System.Drawing.Size(75, 23);
            this.btnEnterPin.TabIndex = 5;
            this.btnEnterPin.Text = "Enter PIN ";
            this.btnEnterPin.UseVisualStyleBackColor = true;
            this.btnEnterPin.Click += new System.EventHandler(this.btnEnterPin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterPin);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lstWithdrawAmounts);
            this.Controls.Add(this.lblWithdrawAmounts);
            this.Controls.Add(this.txtPinNumber);
            this.Controls.Add(this.lblPinNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPinNumber;
        private System.Windows.Forms.TextBox txtPinNumber;
        private System.Windows.Forms.Label lblWithdrawAmounts;
        private System.Windows.Forms.ListBox lstWithdrawAmounts;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnEnterPin;
    }
}

