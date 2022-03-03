using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
    class Cricket
    {
        int sum = 0, Avg;
        public void PointsCalculation(int no_of_matches)
        {
            int[] score = new int[10];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter  Match {0} Score", i + 1);
                score[i] = Convert.ToInt32(Console.ReadLine());
                sum += score[i];
            }
            Avg = sum / no_of_matches;
            Console.WriteLine("Sum of the Scores:{0}\nAverage of the Scores:{1}", sum, Avg);
        }
    }
        class CrickeetPrj
        {
            static void Main(string[] args)
            {
                int n;
                Cricket c = new Cricket();
                Console.WriteLine("Enter No Of Matches");
                n = Convert.ToInt32(Console.ReadLine());
                c.PointsCalculation(n);

            }
        }
}
