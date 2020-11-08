using System;
using System.Collections.Generic;
using System.Text;

namespace HWs
{
    static public class Arrays1D
    {
        public static int FindSmallestElemenInArray(int[] arr)
        {
            int min;
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int FindBiggestElementInArray(int[] arr)
        {
            int max;
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int FindIndexOfSmallestElementInArray(int[] arr)
        {
            int minI = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (minI > arr[i])
                {
                    minI = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FindIndexOfBiggestElementInArray(int[] arr)
        {
            int maxI = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxI < arr[i])
                {
                    maxI = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int AddAllElementsWithOddIndex(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                c = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = c;
            }
            return arr;
        }    
        
        public static int CountOddArrayElements(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int[] SwapHalfOfArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                if (arr.Length % 2 == 0)
                {
                    arr[i] = arr[(arr.Length / 2) + i];
                    arr[(arr.Length / 2) + i] = temp;
                }
                else
                {
                    arr[i] = arr[(arr.Length / 2) + i + 1];
                    arr[(arr.Length / 2) + i + 1] = temp;
                }

            }
            return arr;
        }
            
        public static int[] SortArrayByAscendingSelect(int[] arr)
        {
            //выбирается минимальный элемент и кладётся в начало массива, 
            //потом следующий мин элемент кладётся на след место
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    int mini = arr[i];
                    if (arr[j] > mini)
                    {
                        mini = arr[j];
                        arr[j] = arr[i];
                        arr[i] = mini;
                    }
                }
            }
            return arr;
        }

        public static int[] SortArrayByDescendingBubble(int[] arr)
        {
            int x = 0;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        x = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = x;
                    }
                }

            }
            return arr;
        }
            
    }
}
