using NUnit.Framework;
using HWs;

namespace HWs.Tests
{
    class LoopsTests
    {
        [TestCase(2, 4, 16)]
        [TestCase(5, 8, 390625)]
        [TestCase(3, 2, 9)]
        public void ElevateNumberTest(int a, int b, int expected)
        {
            int actual = Loops.ElevateNumber(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[10] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        //[TestCase()]
        //[TestCase()]
        public void ReturnNumbersDividableByATest(int a, int[] expected)
        {
            int[] actual = Loops.ReturnNumbersDividableByA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 2)]
        [TestCase(0, 0)]
        [TestCase(100, 9)]
        public void ReturnAmountOfNumbersSmallerThanASquareTest(int a, int expected)
        {
            int actual = Loops.ReturnAmountOfNumbersSmallerThanASquare(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(66, 33)]
        [TestCase(57, 19)]
        [TestCase(-20, 10)]
        public void ReturnBiggestDividerTest(int a, int expected)
        {
            int actual = Loops.ReturnBiggestDivider(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 30, 70)]
        [TestCase(52, 4, 196)]
        [TestCase(-20, -100, -714)]
        public void ReturnSumOfNumbersFromAToBDividableBy7Test(int a, int b, int expected)
        {
            int actual = Loops.ReturnSumOfNumbersFromAToBDividableBy7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 34)]
        [TestCase(10, 144)]
        [TestCase(35, 24157817)]
        public void ShowNthNumberInFibonacciSequenceTest(int n, int expected)
        {
            int actual = Loops.ShowNthNumberInFibonacciSequence(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(63, 5, 1)]
        [TestCase(7, 98, 7)]
        [TestCase(49, 6, 1)]
        public void FindBiggestCommonDividerEuclidianTest(int a, int b, int expected)
        {
            int actual = Loops.FindBiggestCommonDividerEuclidian(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 5)]
        [TestCase(64, 4)]
        [TestCase(343, 7)]
        public void FindCubicRootOfANumberByDividingInHalfTest(int x, int expected)
        {
            int actual = Loops.FindCubicRootOfANumberByDividingInHalf(x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 2)]
        [TestCase(64, 0)]
        [TestCase(343, 2)]
        public void FindAmountOfOddDigitsInNumberTest(int n, int expected)
        {
            int actual = Loops.FindAmountOfOddDigitsInNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 521)]
        [TestCase(64, 46)]
        [TestCase(349, 943)]
        public void MirrorNumberTest(int n, int expected)
        {
            int actual = Loops.MirrorNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 54)]
        [TestCase(236, 101)]
        [TestCase(49, 24)]
        public void FindAmountOfNumbersWithBiggerSumOfEvenDigitsTest(int n, int expected)
        {
            int actual = Loops.FindAmountOfNumbersWithBiggerSumOfEvenDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 543, true)]
        [TestCase(236, 1, false)]
        [TestCase(49, 0, false)]
        public void FindSameDigitsInTwoNumbersTest(int a, int b, bool expected)
        {
            bool actual = Loops.FindSameDigitsInTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
