using System;


//The programs prints the largest element in each row of a multidimensional array
namespace scenario3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers;

            numbers = new int[4][];

            numbers[0] = new[] { 5, 2, 1, 3, 0 };
            numbers[1] = new[] { 6, 10, 4, 3, 13 };
            numbers[2] = new[] { 5, 0, 3, 2, 9 };
            numbers[3] = new[] { 7, 2, 5, 3, 8 };

            //Display unsorted array
            Console.WriteLine("\tUnsorted array");
            displayArray(numbers, 4, 5);

            //int[][] number = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = bubblesort(numbers[i]);
            }

            //Display sorted array
            Console.WriteLine("\tsorted array");
            displayArray(numbers, 4, 5);

            //Prints the highest element in each row.
            for (int i = 0; i < 4; i++)
                Console.WriteLine("Highest element in row {0} is {1}", i + 1, numbers[i][4]);
        }

        public static void displayArray(int[][] numbers, int r, int c)
        {
            for (int n = 0; n < r; n++) {
                for (int m = 0; m < c; m++)
                {
                    Console.Write(numbers[n][m] + " ");

                }
                Console.WriteLine();
            }
        

            return;
        }

        public static int[] bubblesort(int[] numbers)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
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
