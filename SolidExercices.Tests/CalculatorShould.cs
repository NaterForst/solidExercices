using System;
using System.Linq;
using System.Net.Mime;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");

            Check.That(result).IsEqualTo(3.3)
        }

        [Test]
        public void CalculateAMultiplication()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5*5");
            
            Check.That(result).IsEqualTo(25);
        }
        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("10/2");

            Check.That(result).IsEqualTo(5);
        }
        [Test]
        public void CalculateASustraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("10-5");
            Check.That(result).IsEqualTo(5);

        }
        
        [Test]
        public void CalculateASumManyOperand()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("10+5+10");
            Check.That(result).IsEqualTo(25);

        }      

      }
}


        
