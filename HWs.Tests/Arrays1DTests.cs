using NUnit.Framework;
using HWs;

namespace HWs.Tests
{
    class Arrays1DTests
    {
        [TestCase(new int[3] { 5, 0, 10 }, 0)]
        [TestCase(new int[4] { 9, 20, 1, 8 }, 1)]
        [TestCase(new int[4] { -5, -7, 100, 2 }, -7)]
        public void FindSmallestElemenInArrayTest(int[] arr, int expected)
        {
            int actual = Arrays1D.FindSmallestElemenInArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[3] { 5, 0, 10 }, 10)]
        [TestCase(new int[4] { 9, 20, 1, 8 }, 20)]
        [TestCase(new int[4] { -5, -7, 100, 2 }, 100)]
        public void FindBiggestElementInArrayTest(int[] arr, int expected)
        {
            int actual = Arrays1D.FindBiggestElementInArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[3] { 5, 0, 10 }, 1)]
        [TestCase(new int[4] { 9, 20, 1, 8 }, 2)]
        [TestCase(new int[4] { -5, -7, 100, 2 }, 1)]
        public void FindIndexOfSmallestElementInArrayTest(int[] arr, int expected)
        {
            int actual = Arrays1D.FindIndexOfSmallestElementInArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[3] { 5, 0, 10 }, 2)]
        [TestCase(new int[4] { 9, 20, 1, 8 }, 1)]
        [TestCase(new int[4] { -5, -7, 100, 2 }, 2)]
        public void FindIndexOfBiggestElementInArrayTest(int[] arr, int expected)
        {
            int actual = Arrays1D.FindIndexOfBiggestElementInArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 5, 0, 10, 2, 4 }, 2)]
        [TestCase(new int[7] { 9, 20, 1, 8, 3, 12, 7 }, 40)]
        [TestCase(new int[6] { -5, -7, 100, 2, 1, -10 }, -15)]
        public void AddAllElementsWithOddIndexTest(int[] arr, int expected)
        {
            int actual = Arrays1D.AddAllElementsWithOddIndex(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 5, 0, 10, 2, 4 }, new int[5] { 4, 2, 10, 0, 5 })]
        [TestCase(new int[7] { 9, 20, 1, 8, 3, 12, 7 }, new int[7] { 7, 12, 3, 8, 1, 20, 9 })]
        [TestCase(new int[6] { -5, -7, 100, 2, 1, -10 }, new int[6] { -10, 1, 2, 100, -7, -5 })]
        public void ReverseArrayTest(int[] arr, int[] expected)
        {
            int[] actual = Arrays1D.ReverseArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 5, 0, 10, 2, 4 }, 1)]
        [TestCase(new int[7] { 9, 20, 1, 8, 3, 12, 7 }, 4)]
        [TestCase(new int[6] { -5, -7, 100, 2, 1, -10 }, 3)]
        public void CountOddArrayElementsTest(int[] arr, int expected)
        {
            int actual = Arrays1D.CountOddArrayElements(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 5, 0, 10, 2, 4 }, new int[5] { 2, 4, 10, 5, 0 })]
        [TestCase(new int[7] { 9, 20, 1, 8, 3, 12, 7 }, new int[7] { 3, 12, 7, 8, 9, 20, 1 })]
        [TestCase(new int[6] { -5, -7, 100, 2, 1, -10 }, new int[6] { 2, 1, -10, -5, -7, 100 })]
        public void SwapHalfOfArray(int[] arr, int[] expected)
        {
            int[] actual = Arrays1D.SwapHalfOfArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 5, 0, 10, 2, 4 }, new int[5] { 0, 2, 4, 5, 10 })]
        [TestCase(new int[7] { 9, 20, 1, 8, 3, 12, 7 }, new int[7] {1, 3, 7, 8, 9, 12, 20})]
        [TestCase(new int[6] { -5, -7, 100, 2, 1, -10 }, new int[6] { -10, -7, -5, 1, 2, 100})]
        public void SortArrayByAscendingSelectTest(int[] arr, int[] expected)
        {
            int[] actual = Arrays1D.SortArrayByAscendingSelect(arr);
            Assert.AreEqual(expected, actual);
        }

    }
}
