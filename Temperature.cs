using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Temperature
    {
        static void Main(string[] args)
        {
            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Celsius:" + celsius);

            fahrenheit = ((celsius * 9) / 5 + 32);
            Console.WriteLine("fahrenheit:" + fahrenheit);
            Console.ReadLine();
        }
    }
}
