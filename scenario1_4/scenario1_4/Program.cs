using System;

namespace scenario1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 56, result;

            result = SignificantDigits(n);
            Console.WriteLine("The number of significant digits in {0} is {1}", n, result);
        }

        private static int SignificantDigits(int n)
        {
            if(n/10 == 0 && n != 0)
            {
                return 1;
            }
            else
            {
                return 1 + SignificantDigits(n / 10);
            }
        }
    }
}
