using System;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int n;
            string s;

            Console.Write("Enter number of numbers to sort: ");
            
            try
            {
                s = Console.ReadLine();
                n = Convert.ToInt32(s);

            }
            catch (Exception ice)
            {
                Console.WriteLine("\nError message: " + ice.Message);
                Console.WriteLine("End of program ...");
                return; //Program terminates if user enters the wrong input, not a number
            }

            numbers = new int[n];

            Console.WriteLine("Enter " + n + " numbers to sort");

            //Reads user input
            for(int i = 0; i < n; i++)
            {
                string temp;

                temp = Console.ReadLine(); //Reads number from the input, assumes user enters the correct input

                numbers[i] = Convert.ToInt32(temp);
            }

            displayArray(numbers);
            numbers = bubblesort(numbers);

            displayArray(numbers);
            return;
        }

        public static void displayArray(int[] numbers)
        {
            //Prints sorted numbers
            Console.WriteLine();

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        public static int[] bubblesort(int[] numbers)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if(numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }

                }
            } while (swapped == true);

            return numbers;
        }
    }
}
