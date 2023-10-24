using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        //Declare vending machine object
        VendingMachine vendingmachine1;
    

        public Form1()
        {
            InitializeComponent();

            vendingmachine1 = new VendingMachine();
        }

        private void btnBuyChocolate_Click(object sender, EventArgs e)
        {
            //Buy chocolate
            int chocolateAmount = int.Parse(txtChocolateAmount.Text);
            vendingmachine1.BuyChocolate(chocolateAmount);
        }

        private void btnBuyCrisps_Click(object sender, EventArgs e)
        {
            int crispAmount = int.Parse(txtCrispAmount.Text);
            vendingmachine1.BuyCrisps(crispAmount);
        }

        private void btnBuyWater_Click(object sender, EventArgs e)
        {
            int waterAmount = int.Parse(txtWaterAmount.Text);
            vendingmachine1.BuyWater(waterAmount);
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            string stockItem = txtCheckStock.Text;
            MessageBox.Show(stockItem + " stock level is currently at " + vendingmachine1.GetStock(stockItem).ToString());
        }
    }
}
