using System;

namespace for_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
        }

        private static void ForTest()
        {
            for(int i = 1; i <=5; i++)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
        }
    }
}
