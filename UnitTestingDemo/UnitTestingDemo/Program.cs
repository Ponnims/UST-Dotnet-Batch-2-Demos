using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(5, 3);
            int difference = calculator.Subtract(5, 3);
            int product = calculator.Multiply(5, 3);
            double quotient = calculator.Divide(5, 3);

        }
    }
}
