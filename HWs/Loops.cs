using System;
using System.Collections.Generic;
using System.Text;

namespace HWs
{
    static public class Loops
    {
        public static int ElevateNumber (int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c *= a;
            }
            return c;
            //сделать для отрицательной степени или вкинуть эксепшн
        }
        public static int[] ReturnNumbersDividableByA(int a)
        {
            int counter = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    counter++;
                }
            }
            int[] nums = new int[counter];
            counter = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    nums[counter] = i;
                    counter++;
                }
            }
            return nums;
        }
        public static int ReturnAmountOfNumbersSmallerThanASquare(int a)
        {
            int counter = 0;
            for (int i = 1; i <= a; i++)
            {
                if (i * i < a)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int ReturnBiggestDivider(int a)
        {
            int del = 0;
            if (a < 0)
            {
                a *= -1;
            }
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    del = i;
                }
            }
            return del;
        }
        public static int ReturnSumOfNumbersFromAToBDividableBy7(int a, int b)
        {
            int c = 0;
            int temp = 0;
            if (b < a)
            {
                c = a;
                a = b;
                b = c;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    temp += i;
                }
            }
            return temp;
        }
        public static int ShowNthNumberInFibonacciSequence(int n)
        {
            int f1 = 1;
            int f2 = 1;
            int f3 = 0;
            for (int i = 0; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }
        public static int FindBiggestCommonDividerEuclidian(int a, int b)
        {
            int c = 0;
            while (!(a % b == 0))
            {
                c = a % b;
                a = b;
                b = c;
            }
            return c;
        }
        public static int FindCubicRootOfANumberByDividingInHalf(int x)
        {
            int borderL = 0;
            int borderR = 0;
            int n = x;
            while (Math.Pow(n, 3) != x)
            {
                borderR = n / 2;
                if (Math.Pow(borderR, 3) > x)
                {
                    borderR /= 2;
                    n = borderR;
                }
                else if (Math.Pow(borderR, 3) < x)
                {
                    borderL = n;
                    n = borderL + borderR;
                    if (Math.Pow(n,3) > x)
                    {
                        n /= 2;
                    }
                }
            }
            return n;
        }
        public static int FindAmountOfOddDigitsInNumber(int n)
        {
            int counter = 0;
            while (!(n % 10 == 0))
            {
                if ((n % 10) % 2 != 0)
                {
                    counter++;
                }
                n /= 10;
            }
            return counter;
        }
        public static int MirrorNumber(int n)
        {
            int t = 0;
            while (!(n % 10 == 0))
            {
                t += n % 10;
                n /= 10;
                if (!(n % 10 == 0))
                {
                    t *= 10;
                }
            }
            return t;
        }
        public static int FindAmountOfNumbersWithBiggerSumOfEvenDigits(int n)
        {
            int t = 0;
            int d = 0;
            int p = 0;
            ////Создать диапазон чисел
            //    //Взять цифру из числа
            //        //Если чётная прибавить к к1
            //        //Если нечётная прибавить к к2
            //    //перейти к следующей цифре
            ////Если к1 больше к2 вывести число
            for (int i = 1; i <= n; i++)
            {
                t = i;
                int k1 = 0;
                int k2 = 0;
                while (!(t == 0))
                {
                    d = t % 10;
                    if (d % 2 == 0)
                    {
                        k1 += d;
                    }
                    else if (d % 2 != 0)
                    {
                        k2 += d;
                    }

                    t /= 10;
                }

                if (k1 > k2)
                {
                    p++;
                }
            }
            return p;
        }
        public static bool FindSameDigitsInTwoNumbers (int a, int b)
        {
            int temp1 = 0;
            int temp2 = 0;
            int digit1 = 0;
            int digit2 = 0;
            bool yn = false;
            //    //цифра первого числа
            //    //сравнивается со всеми цифрами второго числа
            //    //если совпадение бул тру
            //    //если бул тру то вывод ДА
            //    //иначе вывод НЕТ
            temp1 = a;
            while (temp1 != 0)
            {
                digit1 = temp1 % 10;
                temp2 = b;
                while (temp2 != 0)
                {
                    digit2 = temp2 % 10;
                    if (digit1 == digit2)
                    {
                        yn = true;
                    }
                    temp2 /= 10;
                }
                temp1 /= 10;
            }
            return yn;
        }
           

    }
}
