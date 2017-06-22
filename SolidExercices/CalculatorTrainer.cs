using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly string[] _operations = new[] {"1+2,3", "2 x 3,6","6-1-3,8","6,6/3","6/0","not an operation","a+1","12",""};

        public void Run()
        {
            var calculator = new Calculator();
            foreach (var operation in _operations)
            {
                try
                {
                    var reusult = calculator.Calculate(operation);
                    Console.WriteLine(operation + "=");
                }
                catch(Exception e)
                {
                    Console.WriteLine(("error"+ e.Message));
                }
            }
        }
    }
}