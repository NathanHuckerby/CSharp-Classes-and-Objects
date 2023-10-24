using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    internal class ATM
    {
        //attributes
        protected int money;
        protected bool pinCheck;

        //Creates a list of the accepted pin number
        private List<int> ValidPins = new List<int>()
        {
            1234,
            5678,
            9101
        };

        public ATM()
        {
            money = 1000;
            pinCheck = false;
            
        }

        //Checks if the pin number entered is valid or not
        //If it is, pinCheck returns true
        //If it isnt, pinCheck returns false
        public bool checkPin(int pinNumber)
        {
            if (ValidPins.Contains(pinNumber)) 
            {
                pinCheck = true;
            }
            else 
            {
                pinCheck = false;
                
            }
            return pinCheck;

        }

        //Checks if the pinCheck is true and the money is more than the requested withdraw amount
        //If it is, the withdraw happens
        //If it isnt, the function will return false
        public bool Withdraw(int withdrawAmount)
        {
            if (pinCheck == true && money >= withdrawAmount) 
            {
                money -= withdrawAmount;
                
                return true;
            }
            else
            {
                return false;
            }

        }
        //Gets the value of the money
        public int getMoney() 
        { 
            return money; 
        }
    }
}
