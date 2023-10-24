using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Declaring calculator object
        Calculator calculator1;
        public Form1()
        {
            InitializeComponent();
            calculator1 = new Calculator();
        }
         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculator1.number1 = int.Parse(txtFirstNumber.Text);
            calculator1.number2 = int.Parse(txtSecondNumber.Text);
            int result = calculator1.Add();
            txtAdd.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculator1.number1 = int.Parse(txtFirstNumber.Text);
            calculator1.number2 = int.Parse(txtSecondNumber.Text);
            int result = calculator1.Subtract();
            txtSubtract.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculator1.number1 = int.Parse(txtFirstNumber.Text);
            calculator1.number2 = int.Parse(txtSecondNumber.Text);
            int result = calculator1.Multiply();
            txtMultiply.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculator1.number1 = int.Parse(txtFirstNumber.Text);
            calculator1.number2 = int.Parse(txtSecondNumber.Text);
            int result = calculator1.Divide();
            txtDivide.Text = result.ToString();
        }
    }
}
