using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Concession
    {
        int TotalFare = 500, age;
        double Calculate_Fare, Fare;
        public void CalculateConcession1()
        {
            Console.WriteLine("Enter age of the Citizen");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 5)
            {
                Console.WriteLine("Littel Champs - Free Ticket");
            }
            else if (age > 60)
            {
                Calculate_Fare = TotalFare * 0.03;
                Fare = TotalFare - Calculate_Fare;
                Console.WriteLine("Senior Citizen has to pay:{0}", Fare);
            }
            else
            {
                Console.WriteLine("Ticket Booked With the payment of {0}", TotalFare);
            }
        }
    }
}
