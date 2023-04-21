using NUnit.Framework;
using System;

namespace _16modul
{
    internal class _16modul
    {
        public class Calculator
        { 
            public int Additional(int a, int b)
            {
                return a + b;
            }
            [Test]
            public void Additional_ReturnCorrectValue()
            {
                Calculator calculator = new Calculator();
                Assert.That(calculator.Additional(30, 10) == 40);
            }


            public int Subtraction(int a, int b)
            {
                return a - b;
            }
            [Test]
            public void Subtraction_ReturnCorrectValue()
            {
                Calculator calculator = new Calculator();
                Assert.That(calculator.Subtraction(30, 10) == 20);
            }


            public int Miltiplication(int a, int b)
            {
                return a * b;
            }
            [Test]
            public void Miltiplication_ReturnCorrectValue()
            {
                Calculator calculator = new Calculator();
                Assert.That(calculator.Miltiplication(30, 10) == 300);
            }


            public int Division(int a, int b)
            {
                return a / b;
            }
            [Test]
            public void Division_ReturnCorrectValue()
            {
                var calculator = new Calculator();
                Assert.That(calculator.Division(25, 5) == 5);
            }
            [Test]
            public void Division_ByZero()
            {
                var calculator = new Calculator();
                Assert.Throws<DivideByZeroException>(() => calculator.Division(220, 0));
            }
        }
    }
}
