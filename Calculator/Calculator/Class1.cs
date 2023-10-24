using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        //attributes
        public int number1;
        public int number2;
        public int result;

        public Calculator()
        {
            int number1 = 0;
            int number2 = 0;
            int result = 0;
        }

        public int Multiply()
        {
            result = number1 * number2;

            return result;
        }

        public int Divide() 
        {
            result = number1 / number2;

            return result;
        }

        public int Add()
        {
            result = number1 + number2;  
            
            return result;
        }

        public int Subtract() 
        { 
            result = number1 - number2;

            return result;
        }

    }
        
}
