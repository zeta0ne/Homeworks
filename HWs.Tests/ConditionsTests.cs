using NUnit.Framework;
using HWs;

namespace HWs.Tests
{
    public class ConditionsTests
    {
        [TestCase(5, 9, -4)]
        [TestCase(8, 8, 64)]
        [TestCase(10, 3, 13)]
        public void CalculateAAndBTest(int a, int b, int expected)
        {
            int actual = Conditions.CalculateAAndB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 6, 1)]
        [TestCase(-4, -2, 3)]
        [TestCase(8, -5, 4)]
        public void FindQuarterTest(int x, int y, int expected)
        {
            int actual = Conditions.FindQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 2, 4, new int[3] { 2, 4, 9 })]
        [TestCase(100, -7, 10, new int[3] { -7, 10, 100 })]
        [TestCase(5, 90, 1, new int[3] { 1, 5, 90 })]
        public void ArrangeNumbersInAscendingOrderTest(int a, int b, int c, int[] expected)
        {
            int[] actual = Conditions.ArrangeNumbersInAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -2, -3, new double[2] { 3, -1 })]
        [TestCase(-1, -2, 15, new double[2] { -5, 3 })]
        [TestCase(1, 12, 36, new double[1] { -6 })]
        public void SolveQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Conditions.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new string[2] { "Десять", null })]
        [TestCase(27, new string[2] { "Двадцать ", "семь" })]
        [TestCase(99, new string[2] { "Девяносто ", "девять" })]
        public void PrintWordsInsteadOfNumbersTest(int number, string[] expected)
        {
            string[] actual = Conditions.PrintWordsInsteadOfNumbers(number);
            Assert.AreEqual(expected, actual);
        }

    }
}