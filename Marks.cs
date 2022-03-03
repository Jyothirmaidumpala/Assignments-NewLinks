using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Marks
    {
        static void Main()
        {
            string name;
            int n = 3;
            float sum, avg, Maths, Science, Social;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter Student Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter Maths Marks:");
                Maths = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Science Marks:");
                Science = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Social Marks:");
                Social = Convert.ToSingle(Console.ReadLine());
                sum = Maths + Science + Social;
                avg = sum / n;
                if (avg > 50)
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
        }
    }
}
