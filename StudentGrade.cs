using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
     class StudentGrade
    { 
            int Rollno, Sem, sum = 0, avg;
            string name, branch, Class;
            int[] Marks = new int[4];
            public StudentGrade(int rn, string n, string cls, int sem, string br)
            {
                Rollno = rn;
                name = n;
                branch = br;
                Class = cls;
                Sem = sem;
            }
            public void DIsplayResult()
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Enter Subject Marks{0}", i + 1);
                    Marks[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < 4; i++)
                {
                    sum = sum + Marks[i];
                }
                avg = sum / 4;
                Console.WriteLine("The Average Marks of Student is:{0}", avg);
                for (int i = 0; i < 4; i++)
                {
                    if (Marks[i] < 35)
                    {
                        Console.WriteLine("Student is Failed");
                    }
                    else if ((Marks[i] > 35) && (avg < 50))
                    {
                        Console.WriteLine("Student is Failed");
                    }
                    else
                    {
                        Console.WriteLine("Student is Passed");
                    }


                }
            }
            public void DIsplayData()
            {
                Console.WriteLine("ENter the student details:");
                Console.WriteLine("Rollno:{0}\name:{1}\nClass{2}\nSem{3}\nBranch{4}", Rollno, name, branch, Class);
                DIsplayResult();
            }
            public static void Main()
            {
                StudentGrade sd = new StudentGrade(12, "Jyothi", "FinalYear", 8, "Cse");
                sd.DIsplayData();
            }

        
     }
}

