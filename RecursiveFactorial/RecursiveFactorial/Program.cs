using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int result, n = 5;

            result = Factorial(n);
            Console.WriteLine("The factorial of {0} is {1}", n, result);
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
