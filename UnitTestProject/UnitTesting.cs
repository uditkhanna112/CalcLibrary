
using NUnit.Framework;
using System;
using CalcLibrary;

namespace UnitTestProject
{
    [TestFixture]
    public class CalcUnitTests
    {
        SimpleCalculator cs;
        [SetUp]
        public void SetInit()
        {
            cs = new SimpleCalculator();
        }

        [TestCase(45,11,56)]
        public void CheckAddition(double value1, double value2, double expected)
        {
            double result = cs.Addition(value1, value2);

            Assert.AreEqual(expected, result);

        }

        [TestCase(100, 85, 15)]
        [TestCase(75,25,50)]
        public void CheckSubtraction(double value1, double value2, double expected)
        {
            double result = cs.Subtraction(value1, value2);

            Assert.AreEqual(expected, result);

        }

        [TestCase(20, 20, 400)]
        [TestCase(15, 40, 600)]
        public void CheckMultiplication(double value1, double value2, double expected)
        {
            double result = cs.Multiplication(value1, value2);

            Assert.AreEqual(expected, result);

        }


        [TestCase(200, 100, 2)]
        [TestCase(72, 0, 10)]
        public void CheckDivision(double value1, double value2, double expected)
        {
            try
            {
                double result = cs.Division(value1, value2);
                Assert.AreEqual(expected, result);
                Assert.Fail();

            }
            catch(ArgumentException e)
            {
                Assert.Pass("Divide By zero");
            }

        }

        [TestCase(21, 21, 42)]
        public void TestAddAndClear(double value1, double value2, double expected)
        {
            double result = cs.Addition(value1, value2);
            Assert.AreEqual(expected, result);
            cs.AllClear();
            Assert.AreEqual(0, cs.GetResult);
        }

        [TearDown]
        public void MathLibraryDown()
        {
            cs.Dispose();
        }
    }
}
