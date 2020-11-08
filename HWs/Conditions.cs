using System;
using System.Collections.Generic;
using System.Text;

namespace HWs
{
    static public class Conditions
    {
        public static int CalculateAAndB(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else if (a < b)
            {
                return a - b;
            }
            else
            {
                return 0;
            }
        }
        public static int FindQuarter(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
        public static int[] ArrangeNumbersInAscendingOrder(int a, int b, int c)
        {
            int[] arr = new int[3];
            if (a < b && a < c)
            {
                arr[0] = a;
                if (b < c)
                {
                    arr[1] = b;
                    arr[2] = c;
                }
                else
                {
                    arr[1] = c;
                    arr[2] = b;
                }
            }
            else if (b < a && b < c)
            {
                arr[0] = b;
                if (a < c)
                {
                    arr[1] = a;
                    arr[2] = c;
                }
                else
                {
                    arr[1] = c;
                    arr[2] = a;
                }
            }
            else if (c < a && c < b)
            {
                arr[0] = c;
                if (a < b)
                {
                    arr[1] = a;
                    arr[2] = b;
                }
                else
                {
                    arr[1] = b;
                    arr[2] = a;
                }
            }
            return arr;
        }
        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            double dis = b * b - 4 * a * c;
            if (a == 0)
            {
                throw new Exception("Parameter can't equal to 0");
            }
            if (dis < 0)
            {
                return new double[0];
            }
            else if (dis == 0)
            {
                return new double[1] { (b * (-1)) / (2 * a) };
            }
            else
            {
                return new double[2] { (b * (-1) + Math.Sqrt(dis)) / (a * 2), (b * (-1) - Math.Sqrt(dis)) / (a * 2) };
            }
            
        }
        public static string[] PrintWordsInsteadOfNumbers (int number)
        {
            string[] answer = new string[2];
            if (number / 10 < 1 || number / 10 > 9)
            {
                throw new Exception ("Нет, нужно двузначное");
            }
            else
            {
                if (number >= 20 && number <= 99)
                {
                    if (number / 10 == 2)
                    {
                        answer[0] = "Двадцать ";
                    }
                    else if (number / 10 == 3)
                    {
                        answer[0] = "Тридцать ";
                    }
                    else if (number / 10 == 4)
                    {
                        answer[0] = "Сорок ";
                    }
                    else if (number / 10 == 5)
                    {
                        answer[0] = "Пятьдесят ";
                    }
                    else if (number / 10 == 6)
                    {
                        answer[0] = "Шестьдесят ";
                    }
                    else if (number / 10 == 7)
                    {
                        answer[0] = "Семьдесят ";
                    }
                    else if (number / 10 == 8)
                    {
                        answer[0] = "Восемьдесят ";
                    }
                    else if (number / 10 == 9)
                    {
                        answer[0] = "Девяносто ";
                    }

                    if (number % 10 == 2)
                    {
                        answer[1] = "два";
                    }
                    else if (number % 10 == 3)
                    {
                        answer[1] = "три";
                    }
                    else if (number % 10 == 4)
                    {
                        answer[1] = "четыре";
                    }
                    else if (number % 10 == 5)
                    {
                        answer[1] = "пять";
                    }
                    else if (number % 10 == 6)
                    {
                        answer[1] = "шесть";
                    }
                    else if (number % 10 == 7)
                    {
                        answer[1] = "семь";
                    }
                    else if (number % 10 == 8)
                    {
                        answer[1] = "восемь";
                    }
                    else if (number % 10 == 9)
                    {
                        answer[1] = "девять";
                    }
                    else if (number % 10 == 0)
                    {
                        answer[1] = null;
                    }
                }

                if (number >= 10 && number <= 19)
                {
                    if (number % 10 == 0)
                    {
                        answer[0] = "Десять";
                    }
                    else if (number % 10 == 1)
                    {
                        answer[0] = "Одиннадцать";
                    }
                    else if (number % 10 == 2)
                    {
                        answer[0] = "Двенадцать";
                    }
                    else if (number % 10 == 3)
                    {
                        answer[0] = "Тринадцать";
                    }
                    else if (number % 10 == 4)
                    {
                        answer[0] = "Четырнадцать";
                    }
                    else if (number % 10 == 5)
                    {
                        answer[0] = "Пятнадцать";
                    }
                    else if (number % 10 == 6)
                    {
                        answer[0] = "Шестнадцать";
                    }
                    else if (number % 10 == 7)
                    {
                        answer[0] = "Семнадцать";
                    }
                    else if (number % 10 == 8)
                    {
                        answer[0] = "Восемнадцать";
                    }
                    else if (number % 10 == 9)
                    {
                        answer[0] = "Девятнадцать";
                    }
                }
            }
            return answer;
        }
    }

}    
            
