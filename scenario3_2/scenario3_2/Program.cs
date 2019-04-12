using System;
using System.Collections;

//A program to display the content of two sorted queues in sorted order

namespace scenario3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue( new int[]{1, 3, 5, 7, 9});
            Queue q2 = new Queue(new int[] { 2, 4, 6, 8, 10 });


            //While neither queue is empty, compare and display the lowest value first
            while( q1.Count != 0 && q2.Count != 0)
            {
                int temp1, temp2;

                temp1 = Convert.ToInt32(q1.Peek());
                temp2 = Convert.ToInt32(q2.Peek());


                if ( temp1 < temp2)
                {
                    Console.Write(q1.Dequeue() + " ");
                }
                else
                {

                    Console.Write(q2.Dequeue() + " ");
                }

            }

            //Prints all the content of q1
            while(q1.Count != 0)
            {
                Console.Write(q1.Dequeue() + " ");
            }

            //Prints all the content of q2
            while (q2.Count != 0)
            {
                Console.Write(q2.Dequeue() + " ");
            }

            Console.WriteLine();
            return;
        }
    }
}
