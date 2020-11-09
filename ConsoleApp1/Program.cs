using System;
using HWs;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arrays1D.AddAllElementsWithOddIndex(new int[7] { 9, 20, 1, 8, 3, 12, 7 }));
            //Console.WriteLine(Loops.FindAmountOfNumbersWithBiggerSumOfEvenDigits(236));
            //Console.WriteLine(Loops.FindAmountOfNumbersWithBiggerSumOfEvenDigits(49));

            //[TestCase(new int[5] { 5, 0, 10, 2, 4 }, 2)]
            //[TestCase(new int[7] { 9, 20, 1, 8, 3, 12, 7 }, 1)]
            //[TestCase(new int[6] { -5, -7, 100, 2, 1, -10 }, 2)]


            //int[] nums = Loops.ReturnNumbersDividableByA(100);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i] + ", ");
            //}

            //Console.WriteLine(Loops.ElevateNumber(2, 4));
            //Console.WriteLine(Loops.ElevateNumber(5, 8));
            //Console.WriteLine(Loops.ElevateNumber(3, 2));

            //int[,] arr = new int[2, 4];
            //int count = 1;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        arr[i, j] = count;
            //        count++;
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] arr2 = Arrays2D.TransposeArray(arr);
            //Console.WriteLine();
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //double[] arr1 = new double[2];
            //arr1 = Variables.FindEquationCoefficientsForCoordinates(3, 6, -2, -9);
            //Console.WriteLine(arr1[0] + " " + arr1[1]);
            //arr1 = Variables.FindEquationCoefficientsForCoordinates(16, 0, 0, 0);
            //Console.WriteLine(arr1[0] + " " + arr1[1]);
            //arr1 = Variables.FindEquationCoefficientsForCoordinates(-10, -6, 2, 3);
            //Console.WriteLine(arr1[0] + " " + arr1[1]);
        }
    }
}
