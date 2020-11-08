using System;
using System.Collections.Generic;
using System.Text;

namespace HWs
{
    static public class Arrays2D
    {
        public static int FindSmallestElementInArray(int[,] arr)
        {
            int min;
            min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;  
        }
        public static int FindBiggestElementInArray(int[,] arr)
        {
            int max;
            max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        public static int[] FindIndexOfSmallestElementInArray(int [,] arr)
        {
            int iMin = 0;
            int jMin = 0;
            int min;
            min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        iMin = i;
                        jMin = j;
                        min = arr[i, j];
                    }
                }
            }
            return new int[2] { iMin, jMin };
        }
        public static int[] FindIndexOfBiggestElementInArray(int[,] arr)
        {
            int iMax = 0;
            int jMax = 0;
            int max;
            max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        iMax = i;
                        jMax = j;
                        max = arr[i, j];
                    }
                }
            }
            return new int[2] { iMax, jMax };
        }

        public static int FindAmountOfElementsBiggerThanAllNearbyElements (int[,] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i - 1 < 0 || arr[i, j] > arr[i - 1, j])
                        &&
                        (i + 1 >= arr.GetLength(0) || arr[i, j] > arr[i + 1, j])
                        &&
                        (j - 1 < 0 || arr[i, j] > arr[i, j - 1])
                        &&
                        (j + 1 >= arr.GetLength(1) || arr[i, j] > arr[i, j + 1])
                        )
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static int[,] MirrorArrayByMainDiagonal (int[,] arr)
        {
            int c;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(0); j++)
                {
                    c = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = c;
                }
            }
            return arr;
        }

        public static int[,] TransposeArray (int[,] arr)
        {
            int[,] arr2 = new int[arr.GetLength(1), arr.GetLength(0)];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = arr[j, i];
                }
            }
            return arr2;
        }
    }
}
