using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensar_CaseStudy
{
    class App
    {
        public static void Scenario1()
        {
            Console.WriteLine("---------------- Student Scenario 1----------------");
            Info inf = new Info();
            Student student1 = new Student(1, "Jyothi", "28-7-1999");
            Student student2 = new Student(2, "Ajay", "11-02-1997");
            Student student3 = new Student(3, "Surya", "27-03-1998");
            inf.display(student1);
            inf.display(student2);
            inf.display(student3);
        }
        public static void Scenario2()
        {
            Console.WriteLine("---------------- Student Scenario 2----------------");
            Info inf = new Info();
            Student[] std = new Student[3];
            std[0] = new Student(4, "Sindhu", "24-4-2000");
            std[1] = new Student(5, "Sudha", "23-9-1999");
            std[2] = new Student(6, "Vamsi", "3-3-2001");
            for (int i = 0; i < std.Length; i++)
            {
                inf.display(std[i]);
                Console.WriteLine();
            }

        }
        public static void Scenario3()
        {
            Console.WriteLine("---------------- Student Scenario 3----------------");
            Console.WriteLine("Enter the number of details to be inserted");
            int a = Convert.ToInt32(Console.ReadLine());
            Student[] stud = new Student[a];
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("Enter the ID of Student :");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name of Student :");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the DateOfBirth of Student :");
                string DateOfBirth = Console.ReadLine();
                Student s = new Student(Id, Name, DateOfBirth);
                stud[i] = s;
            }
            foreach (var j in stud)
            {
                Console.WriteLine("\nStudent ID:{0}\nStudent Name:{1}\nStudent DOB:{2}\n", j.Id, j.Name, j.DateOfBirth);
            }
        }
        public static void CrScenario1()
        {
            Console.WriteLine("---------------Course Scenario 1----------------");
            Info inf = new Info();
            Course c1 = new Course(1, "Java", "2 Months", 6000);
            Course c2 = new Course(2, "Sql", "1 Month", 5000);
            Course c3 = new Course(3, "Cyber Security", "6 Months", 10000);
            inf.display(c1);
            Console.WriteLine();
            inf.display(c2);
            Console.WriteLine();
            inf.display(c3);
            Console.WriteLine();
        }
        public static void CrScenario2()
        {

            Console.WriteLine("---------------Course Scenario 2----------------");
            Info inf = new Info();
            Course[] c1 = new Course[3];
            c1[0] = new Course(4, "Python", "3 Months", 4000);
            c1[1] = new Course(5, "JQuery", "1 Month", 2000);
            c1[2] = new Course(6, "Networking", "5 Months", 7000);
            for (int i = 0; i < c1.Length; i++)
            {
                inf.display(c1[i]);
                Console.WriteLine();
            }
        }

        public static void CrScenario3()
        {
            Console.WriteLine("---------------- Course Scenario 3----------------");
            Console.WriteLine("Enter the number of details to be inserted");
            int b = Convert.ToInt32(Console.ReadLine());
            Course[] cs = new Course[b];
            for (int i = 0; i < cs.Length; i++)
            {
                Console.WriteLine("Enter the Course ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter  the Course Duration:");
                string Duration = Console.ReadLine();
                Console.WriteLine("Enter the Course Fee:");
                int fee = int.Parse(Console.ReadLine());
                Course cr = new Course(Id, Name, Duration, fee);
                cs[i] = cr;
            }
            foreach (var item in cs)
            {
                Console.WriteLine("\nCourse ID:{0}\nCourse Name:{1}\nCourse Duration:{2}\nCourse Fee:{3}\n", item.CID, item.CName, item.Duration, item.Fees);
            }
        }

        static void Main(string[] args)
        {
            AppEngine apen = new AppEngine();
            StudentAdmin_Details sd = new StudentAdmin_Details();
            sd.showFirstScreen();
            Console.ReadLine();



        }
    }
        
}

