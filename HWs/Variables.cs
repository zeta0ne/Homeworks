using System;

namespace HWs
{
    static public class Variables
    {
        public static int SolveThisEquation(int a, int b)
        {
                return (5 * a + b) / b - a;
        }
        public static int[] SwapTwoNumbers(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            int[] arr = new int[2] { a, b };
            return arr;
        }
        public static int DivideAByB(int a, int b)
        {
            return a / b;
        }
        public static int ReturnDivisionRemainder(int a, int b)
        {
            return a % b;
        }
        public static int SolveStandardLinearEquation(int a, int b, int c)
        {
            return (c - b) / a;
        }
        public static double[] FindEquationCoefficientsForCoordinates(int x1, int y1, int x2, int y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            double[] arr = new double[2] { a, b };
            return arr;
        }
    }
}
