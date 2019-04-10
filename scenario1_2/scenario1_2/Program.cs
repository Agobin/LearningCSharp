using System;

namespace scenario1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int fact;

            Console.Write("Enter the value of n: ");
            n = Console.Read();

            for(fact = 1; n > 1; n--)
            {
                fact = fact*n;

            }

            Console.WriteLine("The value of fact = {0}", fact);
        }
    }
}
