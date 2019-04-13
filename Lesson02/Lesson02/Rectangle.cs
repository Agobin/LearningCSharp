using System;

namespace Lesson02
{
    class Rectangle
    {
        private double length;
        private double width;

        public delegate void RectangleHandler(Rectangle rect);

        public double Length { get; set; }
        public double Width { get; set; }

        /*
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if(value > 0.0)
                {
                    length = value;
                }
            }

        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if(value > 0.0)
                {
                    width = value;
                }
            }
        }

         */
        public double GetArea()
        {
            return length * width;
        }


        public void displayArea(Rectangle rect)
        {
            Console.WriteLine(rect.GetArea());
        }
    }
}
