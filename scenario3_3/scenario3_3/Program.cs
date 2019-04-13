/* Using Stacks
You are writing a program that uses two stacks. The data in each stack is already in descending order. 
You need to process the contents of both stacks in such a way that the output is printed on the screen 
in ascending order. How would you write such a program? */

using System;
using System.Collections;

namespace scenario3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1, s2;

            s1 = new Stack( new int[]{ 1, 3, 5, 7, 9}); //Elements stored in reverse order, top = 9 and tail = 1.
            s2 = new Stack(new int[] { 2, 4, 6, 8, 10});

            
            
            Stack s3, s4;
            s3 = new Stack();
            s4 = new Stack();

            s3 = reverseStack(s1);  //s3 is reversed version of s1
            s4 = reverseStack(s2);  //s4 is reversed version of s2

            //Process and display stack contents in ascending order
            processStacks(s3, s4);

        }

        //Returns a copy of the stack parameter with elements reversed.
        public static Stack reverseStack(Stack s)
        {
            Stack newStack, temp;

            //Initialise variables
            newStack = new Stack();
            temp = (Stack) s.Clone();

            //Transfer elements and store in ascending order
            while(temp.Count != 0)
            {
                newStack.Push(temp.Pop());
            }

            return newStack;
        }

        //Prints stack unreversed assuming stack isn't empty and returns empty stack
        public static void printStack(Stack s)
        {
            //Create a copy of the stark
            Stack temp = new Stack();
            temp = (Stack)s.Clone();

            while(temp.Count != 0)
            {
                Console.Write(temp.Pop() + " ");
            }

        }


        //Prints stack element in reverse order assuming stack isn't empty and returns empty stack
        public static void printStackReverse(Stack s)
        {
            Stack tempStack = new Stack();  //Creates a copy of the stack argument so as not to modify its content
            tempStack = (Stack)s.Clone();
            int temp = Convert.ToInt32(tempStack.Peek());

            //Last element in stack
            if(tempStack.Count == 1)
            {
                Console.Write(temp + " ");
                return;
            }
            else //Stack contains more than one element
            {
                tempStack.Pop();
                printStackReverse(tempStack);
                Console.Write(temp + " ");
            }
        }

        public static void processStacks(Stack s1, Stack s2)
        {
            
            int temp1, temp2;

            while (s1.Count != 0 && s2.Count != 0)
            {

                temp1 = Convert.ToInt32(s1.Peek());  //Holds lowest element in stack1
                temp2 = Convert.ToInt32(s2.Peek());  //Holds lowest element in stack2

                if (temp1 < temp2)
                {
                    Console.Write(s1.Pop() + " ");
                }
                else
                {
                    Console.Write(s2.Pop() + " ");
                }
            }
 
            if(s1.Count != 0)
            {
                printStackReverse(s1);
            }
            
            if(s2.Count != 0)
            {   //Stack2 isn't empty
                printStackReverse(s2);
            }

        }
    }


}
