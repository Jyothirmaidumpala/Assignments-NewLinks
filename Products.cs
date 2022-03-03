using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
     class Products
    {
        static void Main(string[] args)
        {

            SortedList<double, string> Product = new SortedList<double, string>();
            Console.WriteLine("Enter 5 Product Details:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Product{0} Details:", i + 1);
                Console.WriteLine("Enter ProductPrice and ProductName");
                Product.Add(Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            }
            Console.WriteLine("After Sorting the Price of Products is:");
            foreach (KeyValuePair<double, string> Pr in Product)
            {
                Console.WriteLine("ProductName:{1}\nProductPrice:{0}", Pr.Key, Pr.Value);
            }

        }
    }
}
