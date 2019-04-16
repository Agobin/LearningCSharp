using System;

namespace scenario2_1
{
    struct Location
    {
        int x, y, z;
    }

    class Program
    {
        static void Main(string[] args) 
        {
        }
    }

    public class Product
    {
        private string name;

        public Product()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value == "")
                {
                    throw new InvalidCastException();
                }
                else
                    name = value;
            }


        }

        public override string ToString()
        {
            return "The name of this product is " + name;
        }
    }
}
