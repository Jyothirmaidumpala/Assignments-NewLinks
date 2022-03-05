using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensar_CaseStudy
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public Student(int Id, string Name, string DateOfBirth)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }
    }
    class Course
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public int Fees { get; set; }

        public Course(int CID, string CName, string Duration, int Fees)
        {
            this.CID = CID;
            this.CName = CName;
            this.Duration = Duration;
            this.Fees = Fees;
        }
    }
        class Info
    {
        public void display(Student s)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student ID:" + s.Id);
            Console.WriteLine("Student Name:" + s.Name);
            Console.WriteLine("Student DOB:" + s.DateOfBirth);
        }

        public void display(Course c)
        {
            Console.WriteLine("Course Details:");
            Console.WriteLine("Course ID:" + c.CID);
            Console.WriteLine("Course Name:" + c.CName);
            Console.WriteLine("Course Duration:" + c.Duration);
            Console.WriteLine("Course Fee:" + c.Fees);
        }
    }
}
