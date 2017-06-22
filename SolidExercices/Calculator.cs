using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            if (operation.Contains('x'))
            {
                string[] splitOperation = operation.Split('x');
                return Convert.ToDouble(splitOperation[0]) * Convert.ToDouble(splitOperation[1]);
            }
            else if (operation.Contains('+'))
            {
                string[] splitOperation = operation.Split('+');
                return Convert.ToDouble(splitOperation[0]) + Convert.ToDouble(splitOperation[1]);
            }
            else if (operation.Contains('-'))
            {
                string[] splitOperation = operation.Split('-');
                return Convert.ToDouble(splitOperation[0]) - Convert.ToDouble(splitOperation[1]);
            }
            else if (operation.Contains('/'))
            {
                string[] splitOperation = operation.Split('/');
                return Convert.ToDouble(splitOperation[0]) / Convert.ToDouble(splitOperation[1]);
            }
            else
            {
                return 0;
            }
        }
    }
}