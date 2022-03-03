using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StringReverse
    {
        public static void Main()
        {
            string str, str1 = "";
            int i, l;
            Console.Write("Enter  A String : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
            Console.Write("\n");
        }
    }
}
