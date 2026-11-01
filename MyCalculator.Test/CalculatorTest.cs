using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculator.Tests
{
    [TestClass]

    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator calc = new Calculator();

            int res = calc.Add(7, 5);

            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void Add_BigNumber_Test()
        {
            {
                Calculator calc = new Calculator();

                int res = calc.Add(2_147_483_647, 13);

                Assert.IsGreaterThan(2_147_483_647, res);
            }
        }
    }
}
