using System;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"C:\Users\Isidore\Desktop\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
