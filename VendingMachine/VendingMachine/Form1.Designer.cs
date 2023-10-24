namespace VendingMachine
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
            this.lblChocolateAmount = new System.Windows.Forms.Label();
            this.txtChocolateAmount = new System.Windows.Forms.TextBox();
            this.lblCrispAmount = new System.Windows.Forms.Label();
            this.txtCrispAmount = new System.Windows.Forms.TextBox();
            this.lblWaterAmount = new System.Windows.Forms.Label();
            this.txtWaterAmount = new System.Windows.Forms.TextBox();
            this.btnBuyChocolate = new System.Windows.Forms.Button();
            this.btnBuyCrisps = new System.Windows.Forms.Button();
            this.btnBuyWater = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.lblCheckStock = new System.Windows.Forms.Label();
            this.txtCheckStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblChocolateAmount
            // 
            this.lblChocolateAmount.AutoSize = true;
            this.lblChocolateAmount.Location = new System.Drawing.Point(95, 38);
            this.lblChocolateAmount.Name = "lblChocolateAmount";
            this.lblChocolateAmount.Size = new System.Drawing.Size(105, 13);
            this.lblChocolateAmount.TabIndex = 0;
            this.lblChocolateAmount.Text = "Amount of chocolate";
            // 
            // txtChocolateAmount
            // 
            this.txtChocolateAmount.Location = new System.Drawing.Point(82, 68);
            this.txtChocolateAmount.Name = "txtChocolateAmount";
            this.txtChocolateAmount.Size = new System.Drawing.Size(131, 20);
            this.txtChocolateAmount.TabIndex = 1;
            // 
            // lblCrispAmount
            // 
            this.lblCrispAmount.AutoSize = true;
            this.lblCrispAmount.Location = new System.Drawing.Point(365, 38);
            this.lblCrispAmount.Name = "lblCrispAmount";
            this.lblCrispAmount.Size = new System.Drawing.Size(86, 13);
            this.lblCrispAmount.TabIndex = 2;
            this.lblCrispAmount.Text = "Amount of Crisps";
            // 
            // txtCrispAmount
            // 
            this.txtCrispAmount.Location = new System.Drawing.Point(346, 68);
            this.txtCrispAmount.Name = "txtCrispAmount";
            this.txtCrispAmount.Size = new System.Drawing.Size(122, 20);
            this.txtCrispAmount.TabIndex = 3;
            // 
            // lblWaterAmount
            // 
            this.lblWaterAmount.AutoSize = true;
            this.lblWaterAmount.Location = new System.Drawing.Point(627, 38);
            this.lblWaterAmount.Name = "lblWaterAmount";
            this.lblWaterAmount.Size = new System.Drawing.Size(84, 13);
            this.lblWaterAmount.TabIndex = 4;
            this.lblWaterAmount.Text = "Amount of water";
            // 
            // txtWaterAmount
            // 
            this.txtWaterAmount.Location = new System.Drawing.Point(607, 68);
            this.txtWaterAmount.Name = "txtWaterAmount";
            this.txtWaterAmount.Size = new System.Drawing.Size(123, 20);
            this.txtWaterAmount.TabIndex = 5;
            // 
            // btnBuyChocolate
            // 
            this.btnBuyChocolate.Location = new System.Drawing.Point(86, 157);
            this.btnBuyChocolate.Name = "btnBuyChocolate";
            this.btnBuyChocolate.Size = new System.Drawing.Size(127, 23);
            this.btnBuyChocolate.TabIndex = 6;
            this.btnBuyChocolate.Text = "Buy chocolate";
            this.btnBuyChocolate.UseVisualStyleBackColor = true;
            this.btnBuyChocolate.Click += new System.EventHandler(this.btnBuyChocolate_Click);
            // 
            // btnBuyCrisps
            // 
            this.btnBuyCrisps.Location = new System.Drawing.Point(346, 157);
            this.btnBuyCrisps.Name = "btnBuyCrisps";
            this.btnBuyCrisps.Size = new System.Drawing.Size(127, 23);
            this.btnBuyCrisps.TabIndex = 7;
            this.btnBuyCrisps.Text = "Buy crisps";
            this.btnBuyCrisps.UseVisualStyleBackColor = true;
            this.btnBuyCrisps.Click += new System.EventHandler(this.btnBuyCrisps_Click);
            // 
            // btnBuyWater
            // 
            this.btnBuyWater.Location = new System.Drawing.Point(607, 157);
            this.btnBuyWater.Name = "btnBuyWater";
            this.btnBuyWater.Size = new System.Drawing.Size(127, 23);
            this.btnBuyWater.TabIndex = 8;
            this.btnBuyWater.Text = "Buy water";
            this.btnBuyWater.UseVisualStyleBackColor = true;
            this.btnBuyWater.Click += new System.EventHandler(this.btnBuyWater_Click);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(335, 349);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(116, 23);
            this.btnCheckStock.TabIndex = 9;
            this.btnCheckStock.Text = "Check stock level";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // lblCheckStock
            // 
            this.lblCheckStock.AutoSize = true;
            this.lblCheckStock.Location = new System.Drawing.Point(315, 269);
            this.lblCheckStock.Name = "lblCheckStock";
            this.lblCheckStock.Size = new System.Drawing.Size(153, 13);
            this.lblCheckStock.TabIndex = 10;
            this.lblCheckStock.Text = "Enter item to check stock level";
            // 
            // txtCheckStock
            // 
            this.txtCheckStock.Location = new System.Drawing.Point(307, 302);
            this.txtCheckStock.Name = "txtCheckStock";
            this.txtCheckStock.Size = new System.Drawing.Size(166, 20);
            this.txtCheckStock.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCheckStock);
            this.Controls.Add(this.lblCheckStock);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnBuyWater);
            this.Controls.Add(this.btnBuyCrisps);
            this.Controls.Add(this.btnBuyChocolate);
            this.Controls.Add(this.txtWaterAmount);
            this.Controls.Add(this.lblWaterAmount);
            this.Controls.Add(this.txtCrispAmount);
            this.Controls.Add(this.lblCrispAmount);
            this.Controls.Add(this.txtChocolateAmount);
            this.Controls.Add(this.lblChocolateAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChocolateAmount;
        private System.Windows.Forms.TextBox txtChocolateAmount;
        private System.Windows.Forms.Label lblCrispAmount;
        private System.Windows.Forms.TextBox txtCrispAmount;
        private System.Windows.Forms.Label lblWaterAmount;
        private System.Windows.Forms.TextBox txtWaterAmount;
        private System.Windows.Forms.Button btnBuyChocolate;
        private System.Windows.Forms.Button btnBuyCrisps;
        private System.Windows.Forms.Button btnBuyWater;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Label lblCheckStock;
        private System.Windows.Forms.TextBox txtCheckStock;
    }
}

