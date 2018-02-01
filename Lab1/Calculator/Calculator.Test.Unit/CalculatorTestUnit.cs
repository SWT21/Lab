using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTestUnit
    {
        //mr. brix
        [Test]
        public void Add_2plus6_Return_8()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(2, 6), Is.EqualTo(8));
        }

        [Test]
        public void Subtract_2minus6_Return_neg4()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(2, 6), Is.EqualTo(-4));
        }

        [Test]
        public void Multiply_2multiplied6_Return_12()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(2, 6), Is.EqualTo(12));
        }

        [Test]
        public void Power_2exp6_Return_64()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(2, 6), Is.EqualTo(64));
        }


    }
}
