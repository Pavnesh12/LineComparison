using System;

namespace LineCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to line comparison computation program");
            double p1=0, p2=0;
            Console.WriteLine("line comparison computation program");
            Class1 c = new Class1();
          p1 = c.line1();
          p2 = c.line2();
            if (p1 == p2)
            {
                Console.WriteLine("Both line are equal");
            }
            else
            {
                Console.WriteLine("Both line are not equal");
            }


        }
    }
}
