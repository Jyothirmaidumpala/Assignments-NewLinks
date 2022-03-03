using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
    class Stationary
    {
        static void Main()
        {
            List<string> ls = new List<string>();
            ls.Add("Book");
            ls.Add("Plank");
            ls.Add("Eraser");
            ls.Add("Pencil");
            ls.Add("Drafter");
            ls.Add("Booklet");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

