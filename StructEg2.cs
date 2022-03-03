using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement3
{
    struct employee
    {
        public string eName;
        public dob Date;
    }

    struct dob
    {
        public int Day;
        public int Month;
        public int Year;
    }
    class StructEg2
    {
        static void Main(string[] args)
        {
            int dd = 0, mm = 0, yy = 0;

            employee[] emp = new employee[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write(" Enter the name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write(" Enter the day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.Write("ENter the month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.Write("Enter the  year of the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
        }
    }


}

