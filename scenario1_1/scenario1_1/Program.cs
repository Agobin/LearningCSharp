using System;

namespace scenario1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 70;
            ComputeDiscount(n);
        }

        private static void ComputeDiscount(int quantity)
        {
            int discount = 0;

            if (quantity < 10)
                discount = 5;
            else if (quantity < 50)
                discount = 10;
            else if (quantity < 100)
                discount = 15;
            else
                discount = 20;

            Console.WriteLine("The discount applied is: {0}", discount);


        }
    }
}
