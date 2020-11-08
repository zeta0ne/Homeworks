using NUnit.Framework;
using System;
using HWs;

namespace HWs.Tests
{
    class Arrays2DTests
    {
        

        [TestCase(1, 0)]
        [TestCase(2, -1)]
        [TestCase(3, 2)]
        public static void FindSmallestElementInArrayTest(int arrN, int expected)
        {
            int[,] a = GetMockArray(arrN);
            int actual = Arrays2D.FindSmallestElementInArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 16)]
        [TestCase(3, 4)]
        public static void FindBiggestElementInArrayTest(int arrN, int expected)
        {
            int[,] a = GetMockArray(arrN);
            int actual = Arrays2D.FindBiggestElementInArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 1, 4 })]
        [TestCase(2, new int[2] { 1, 1 })]
        [TestCase(3, new int[2] { 0, 0 })]
        public static void FindIndexOfSmallestElementInArrayTest(int arrN, int[] expected)
        {
            int[,] a = GetMockArray(arrN);
            int[] actual = Arrays2D.FindIndexOfSmallestElementInArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 1, 3 })]
        [TestCase(2, new int[2] { 0, 2 })]
        [TestCase(3, new int[2] { 2, 0 })]
        public static void FindIndexOfBiggestElementInArrayTest(int arrN, int[] expected)
        {
            int[,] a = GetMockArray(arrN);
            int[] actual = Arrays2D.FindIndexOfBiggestElementInArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 0)]
        public static void FindAmountOfElementsBiggerThanAllNearbyElementsTest(int arrN, int expected)
        {
            int[,] a = GetMockArray(arrN);
            int actual = Arrays2D.FindAmountOfElementsBiggerThanAllNearbyElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public static void TransposeArrayTest(int arrN, int expN)
        {
            int[,] a = GetMockArray(arrN);
            int[,] expected = GetExpectedTransposedMockArray(expN);
            int[,] actual = Arrays2D.TransposeArray(a);
            Assert.AreEqual(expected, actual);
        }

        static int[,] GetMockArray(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,2,3,4,5 },
                        {6,7,8,9,0 }
                    };
                case 2:
                    return new int[,]
                    {
                        { 3, 9, 16 },
                        { 7, -1, 0 },
                        { 4, 2,  8 }
                    };
                case 3:
                    return new int[,]
                    {
                        { 2, 2, 2 },
                        { 3, 3, 3 },
                        { 4, 4, 4 }
                    };
                default:
                    throw new Exception();
            }
        }

        static int[,] GetExpectedTransposedMockArray(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1, 6 },
                        {2, 7 },
                        {3, 8 },
                        {4, 9 },
                        {5, 0 }
                    };
                case 2:
                    return new int[,]
                    {
                        {3, 7, 4 },
                        {9, -1, 2 },
                        {16, 0, 8 }
                    };
                case 3:
                    return new int[,]
                    {
                        {2, 3, 4 },
                        {2, 3, 4 },
                        {2, 3, 4 }
                    };
                default:
                    throw new Exception();
            }
        }
    }
}
