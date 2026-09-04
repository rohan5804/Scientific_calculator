using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class NumberOperations
    {

        
        public static int factorial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
             int result = 1;
            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static bool prime_number(int n)
        {
            if(n == 0) return false;
            if (n == 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }

            return true;        
        }


        public static bool armstrong(int n)
        {
            int temp = n;
            string result = Convert.ToString(n);
            int size = result.Length;
            int final = 0;
            for (int i = 0; i < size; i++)
            {
                int digit = result[i] - '0'; 
                final += (int)Math.Pow(digit, size);
            }

            return final == temp;
        }

        public static bool palindrome(int n)
        { 
            int temp = n;
            int reverse = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                reverse = reverse * 10 + digit;
                temp /= 10;
            }
            return reverse == n;
        }
    }
}
