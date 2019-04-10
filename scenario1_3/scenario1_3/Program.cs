using System;

namespace scenario1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9, b =3;

            float result = Divide(a, b);

            var x = (result == 0) ? "Invalid Operation" : result.ToString();
            Console.WriteLine("The result of {0} divided by {1} is {2}", a, b, x);
        }

        private static float Divide(int a, int b)
        {
            float result = 0;

            try
            {
                result = a / b;
            }
            catch(DivideByZeroException dbze)
            {
                Console.WriteLine("Divide by zero exception: {0}", dbze.Message);
            }
            catch(InvalidCastException ice)
            {
                Console.WriteLine("Invalid cast operation: {0}", ice.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            
            return result;
        }
    }
}
