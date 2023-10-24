using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    internal class VendingMachine
    {
        //attributes
        protected int chocolate;
        protected int crisps;
        protected int water;

        public VendingMachine()
        {
            chocolate = 100;
            crisps = 100;
            water = 100;

        }

        public void BuyChocolate(int chocolateAmount)
        {
            if (chocolateAmount > chocolate) 
            {
                MessageBox.Show("Purchase of chocolate is currently not available");
            }
            else
            {
                chocolate -= chocolateAmount;
                MessageBox.Show(chocolateAmount + " chocolates bought");
            }
      
        }

        public void BuyCrisps(int crispAmount)
        {
            if (crispAmount > crisps) 
            {
                MessageBox.Show("Purchase of crisps is currently not available");
            }
            else
            {
                crisps -= crispAmount;
                MessageBox.Show(crispAmount + " crisps bought");
            }
        }

        public void BuyWater(int waterAmount) 
        {
            if (waterAmount > water)
            {
                MessageBox.Show("Purchase of water is currently not available");
            }
            else
            {
                water -= waterAmount;
                MessageBox.Show(waterAmount + " waters bought");
            }
        }

        public int? GetStock(string stockItem)
        {
            if (stockItem == "chocolate")
                return chocolate;

            if (stockItem == "crisps")
                return crisps;

            if (stockItem == "water")
                return water;

            return null;

        }


    }
}
