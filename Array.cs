using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Array
    {
        static void Main()
        {
            int[] arr = { 50, 10, 20, 30, 40 };
            int sum = 0;
            int max, min;
            float avg = 0.0F;
            sum = arr.Sum();           
            avg = sum / arr.Length;
            Console.WriteLine($"The average value of array is {avg}");

            max = arr[0];
            min = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("The minimum value of array " + min);
            Console.WriteLine("The maximum value of array " + max);
        }
    }
}

