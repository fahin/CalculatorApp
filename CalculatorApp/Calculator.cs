using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        CalculationClass calculation =new CalculationClass();
        private void addButton_Click(object sender, EventArgs e)
        {
            calculation.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculation.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            calculation.resultNumber = calculation.addFunction();
            resultNumberTextBox.Text = Convert.ToString(calculation.resultNumber);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            calculation.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculation.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            calculation.resultNumber = calculation.subFunction();
            resultNumberTextBox.Text = Convert.ToString(calculation.resultNumber);
        }

        private void MULLButton_Click(object sender, EventArgs e)
        {
            calculation.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculation.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            calculation.resultNumber = calculation.mulFunction();
            resultNumberTextBox.Text = Convert.ToString(calculation.resultNumber);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            calculation.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculation.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            calculation.resultNumber = calculation.divFunction();
            resultNumberTextBox.Text = Convert.ToString(calculation.resultNumber);
        }
    }
}
