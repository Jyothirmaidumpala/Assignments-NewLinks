using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
        class StringCompare
        {
            public static void Main()
            {
                string str1, str2;
                Console.Write("Enter  the 1st string : ");
                str1 = Console.ReadLine();

                Console.Write("Enter the 2nd string : ");
                str2 = Console.ReadLine();
                if (String.Equals(str1, str2))
                {
                    Console.WriteLine($"{str1} and{str2} are equal");
                }
                else
                {
                    Console.WriteLine($"{str1} and {str2} are not equal");
                }


            }
        }
    
}
