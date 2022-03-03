using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class AbstarctStudent
    {
        public String name;
        public int Id;
        public float Grade;
        abstract public Boolean Ispassed(float grade);
    }
    class UG : AbstarctStudent
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter the name of Student:");
            name = Console.ReadLine();
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Enter the Id of the Student");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentID:{0}", Id);

            if (Grade >= 70.0f)
            {
                Console.Write("Result is:");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate : AbstarctStudent
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter the name of Student:");
            name = Console.ReadLine();
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Enter the Id of the Student");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentID:{0}", Id);


            if (Grade >= 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Abstarct
    {
        static void Main()
        {
            UG ug = new UG();
            Console.WriteLine(ug.Ispassed(54.9f));
            Graduate g = new Graduate();
            Console.WriteLine(g.Ispassed(85.3f));

        }
    }


}



