using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number to check:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + "is an even number");
            }
            else
            {
                Console.WriteLine(n + "is an odd number");
            }
        }
    }
}
