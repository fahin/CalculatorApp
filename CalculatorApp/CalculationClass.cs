using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class CalculationClass
    {
        public double firstNumber;
        public double secondNumber;
        public double resultNumber;
        public double addFunction()
        {
            return (firstNumber + secondNumber);
        }
        public double subFunction()
        {
            return (firstNumber - secondNumber);
        }
        public double mulFunction()
        {
            return (firstNumber * secondNumber);
        }
        public double divFunction()
        {
            return (firstNumber / secondNumber);
        }

    }
}
