using System;
using System.Collections.Generic;
using System.Text;

namespace LineCompare
{
    internal class Class1
    {
        int x1, x2, y1, y2;
       double l1 = 0 , l2= 0;
      public double line1()
        {
            Console.WriteLine("enter the co-ordinates x1,y1,x2,y2");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1,y1" + " = "+ x1 + "," + y1);
            Console.WriteLine("x2,y2" + " = "+x2 + "," + y2);
            l1 = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            Console.WriteLine(l1);
            return l1;

        }
        public double line2()
        {
            Console.WriteLine("enter the co-ordinates x1,y1,x2,y2");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1,y1" + " = " + x1 + "," + y1);
            Console.WriteLine("x2,y2" + " = " + x2 + "," + y2);
            l2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return l2;
        }

    }
}
