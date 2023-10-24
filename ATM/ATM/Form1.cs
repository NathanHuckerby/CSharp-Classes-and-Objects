using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        ATM atm1;
        public Form1()
        {
            InitializeComponent();
            atm1 = new ATM();

        }

        //Gets the value of the withdraw amount from the list
        //If the result is true, the withdraw will go through
        //If the result is false, a message will show stating the issue
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int withdrawAmount = int.Parse(lstWithdrawAmounts.Text);
            bool result = atm1.Withdraw(withdrawAmount);
            if (result == true)
            {
                MessageBox.Show("You have withdrew £" + withdrawAmount + ". You now have £" + atm1.getMoney());
            }
            else
            {
                MessageBox.Show("You are unable to withdraw as your PIN number is not accepted or you do not have enough funds");
            }

        }

        //This function will check if the pin number is accepted
        //If it is, the user can start to withdraw
        //If not, the user will not be able to withdraw at all
        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            int pinNumber = int.Parse(txtPinNumber.Text);
            bool result = atm1.checkPin(pinNumber); 
            if (result == true) 
            {
                MessageBox.Show("PIN number accepted");
            }
            else
            {
                MessageBox.Show("PIN number not accepted");
            }
        }
    }
}
