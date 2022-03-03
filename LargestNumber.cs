using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class LargestNumber
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Please a,b,c values:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("{0} is the largest one", a);
            }
            else if (b > c)
            {
                Console.WriteLine("{0} is the largest one", b);
            }
            else
            {
                Console.WriteLine("{0} is the largest one", c);
            }

            //check the smallest one

            if ((a < b) && (a < c))
            {
                Console.WriteLine("{0} is the smallest one", a);
            }
            else if (b < c)
            {
                Console.WriteLine("{0} is the smallest one", b);
            }
            else
            {
                Console.WriteLine("{0} is the smallest one", c);
            }
        }
    }
}
