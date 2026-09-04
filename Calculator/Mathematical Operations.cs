using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Mathematical_Operations
    {
        public static int power(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        public static int HCF(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / HCF(a, b);
        }

        public static int simple_interest(int principal, int rate, int time)
        {
            return (principal * rate * time) / 100;
        }

        public static double compound_interest(double principal, double rate, double time)
        {
            return principal * Math.Pow((1 + rate / 100), time) - principal;
        }

    }
}
