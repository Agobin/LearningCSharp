using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Rectangle s = new Rectangle { Length = 2.0, Width = 2.0 };
            rect.Length = 20.0;
            rect.Width = 10.0;

            double area = rect.GetArea();

            Console.WriteLine("The area of the rectangle is {0}", area);
                
        }
    }
}
