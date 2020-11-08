using NUnit.Framework;
using HWs;

namespace HWs.Tests
{
    public class VariablesTests
    {
        [TestCase(10, 5, 1)]
        [TestCase(7, 15, -4)]
        [TestCase(100, -100, -104)]
        public void SolveThisEquationTest(int a, int b, int expected)
        {
            int actual = Variables.SolveThisEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, new int[2] { 5, 1 })]
        [TestCase(7, 15, new int[2] { 15, 7 })]
        [TestCase(100, -100, new int[2] { -100, 100 })]
        public void SwapTwoNumbersTest(int a, int b, int[] expected)
        {
            int[] actual = Variables.SwapTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(100, 5, 20)]
        public void DivideAByBTest(int a, int b, int expected)
        {
                int actual = Variables.DivideAByB(a, b);
                Assert.AreEqual(expected, actual);
        }

        [TestCase(213, 10 ,3)]
        [TestCase(47, 4, 3)]
        [TestCase(2345, 13, 5)]
        public void ReturnDivisionRemainderTest(int a, int b, int expected)
        {
            int actual = Variables.ReturnDivisionRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 8, 2, -1)]
        [TestCase(2, 6, 10, 2)]
        [TestCase(-2, 4, 24, -10)]
        public void SolveStandardLinearEquationTest(int a, int b, int c, int expected)
        {
            int actual = Variables.SolveStandardLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 6, -2, -9, new double[2] { 3, -3 })]
        [TestCase(16, 0, 0, 0, new double[2] { 0, 0 })]
        [TestCase(-10, -6, 2, 3, new double[2] { 0, 3 })]
        public void FindEquationCoefficientsForCoordinates(int x1, int y1, int x2, int y2, double[] expected)
        {
            double[] actual = Variables.FindEquationCoefficientsForCoordinates(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }


    }
}