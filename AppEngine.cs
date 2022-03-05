using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Zensar_CaseStudy
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlCommand cmd1;
        public static SqlCommand cmd2;
        public static SqlCommand cmd3;
        public static SqlCommand cmd4;
        public static SqlCommand cmd5;
        public static SqlCommand cmd6;
        public static SqlCommand cmd7;
        public static SqlCommand cmd8;
        public static SqlCommand cmd9;

        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=ADMW46ZLPC1174;Initial Catalog=ZensarCaseStudy;Integrated Security=true;");
            con.Open();
            return con;
        }
        public void RegisteredStudents()
        {
            con = getConnection();
            cmd = new SqlCommand("select*from StudentDetails", con);
            //int res = cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Details");
                Console.WriteLine("****************");
                Console.WriteLine("Student Id:" + " " + dr[0]);
                Console.WriteLine("Student Name:" + " " + dr[1]);
                Console.WriteLine("Student DOB:" + " " + dr[2]);
            }

        }
        /*2.New Registration*/
        public void NewStudentRegistration()
        {
            con = getConnection();
            Console.WriteLine("Enter studentId,StudentName,StudentDOB");
            int sid;
            string sname, sdob;
            sid = Convert.ToInt32(Console.ReadLine());
            sname = Console.ReadLine();
            sdob = Console.ReadLine();
            cmd1 = new SqlCommand("insert into StudentDetails values(@Std_id,@Std_Name,@Std_Dob)", con);
            cmd1.Parameters.AddWithValue("@Std_id", sid);
            cmd1.Parameters.AddWithValue("@Std_Name", sname);
            cmd1.Parameters.AddWithValue("@Std_Dob", sdob);
            int res1 = cmd1.ExecuteNonQuery();
            if (res1 > 0)
            {
                Console.WriteLine("Student Details Inserted Successfully");

            }
            else
            {
                Console.WriteLine("Please Enter valid Student details");
            }


        }
        public void UpdateStudents()
        {
            con = getConnection();
            Console.WriteLine("Enter the Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Student DOB:");
            string DateOfBirth = Console.ReadLine();
            cmd6 = new SqlCommand("update StudentDetails set S_Name=@Stud_Name,Stud_dob=@S_Dob where Std_id=@Std_id", con);
            cmd6.Parameters.AddWithValue("@Std_id", Id);
            cmd6.Parameters.AddWithValue("@Stud_Name", Name);
            cmd6.Parameters.AddWithValue("@Stud_Dob", DateOfBirth);
            int res2 = cmd6.ExecuteNonQuery();
            if (res2 > 0)
            {
                Console.WriteLine("Student details Updated Sucessfully");
            }
            else
                Console.WriteLine("please enter valid student details");

        }
        public void StudentDelete()
        {
            con = getConnection();
            Console.WriteLine("Enter Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());
            cmd7 = new SqlCommand("delete Student where Std_id=@Std_id", con);
            cmd7.Parameters.AddWithValue("@Std_id", Id);
            int res3 = cmd7.ExecuteNonQuery();
            if (res3 > 0)
            {
                Console.WriteLine("Row Deleted Sucessfully");
            }
            else
                Console.WriteLine("please enter valid student details");
        }

        public void AvailableCourses()
        {
            con = getConnection();
            cmd3 = new SqlCommand("select*from CourseDetails", con);
            //int res = cmd.ExecuteNonQuery();
            dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details");
                Console.WriteLine("****************");
                Console.WriteLine("Course Id:" + " " + dr[0]);
                Console.WriteLine("Course Name:" + " " + dr[1]);
                Console.WriteLine("Course Duration:" + " " + dr[2]);
                Console.WriteLine("Course Fee:" + " " + dr[3]);
                Console.WriteLine();
            }
        }

        public void IntroduceCourse()
        {
            int n;
            Console.WriteLine("Enter No of Course Details you Want to insert............");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                con = getConnection();
                Console.WriteLine("Enter Course Details CourseId,CourseName,Duration,Fee_Structure");
                int cid, fees;
                string cname, dur;
                cid = Convert.ToInt32(Console.ReadLine());
                cname = Console.ReadLine();
                dur = Console.ReadLine();
                fees = Convert.ToInt32(Console.ReadLine());
                cmd2 = new SqlCommand("insert into Course values (@Cr_id,@Cr_Name,@Cr_dur,@Cr_fee)", con);
                cmd2.Parameters.AddWithValue("@Cr_id", cid);
                cmd2.Parameters.AddWithValue("@Cr_Name", cname);
                cmd2.Parameters.AddWithValue("@Cr_dur", dur);
                cmd2.Parameters.AddWithValue("@Cr_fee", fees);
                int res4 = cmd2.ExecuteNonQuery();
                if (res4 > 0)
                {
                    Console.WriteLine("Course details inserted Sucessfully");
                }
                else
                    Console.WriteLine("Please enter valid Course details");
            }


        }
        public void UpdateCourse()
        {
            con = getConnection();
            int cid, fees;
            string Dur;
            Console.WriteLine("Enter CID:");
            cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Duration:");
            Dur = Console.ReadLine();
            Console.WriteLine("Enter Course Fees:");
            fees = Convert.ToInt32(Console.ReadLine());
            cmd4 = new SqlCommand("update Course set cdur=@dur,cfee=@fee where cid=@cid", con);
            cmd4.Parameters.AddWithValue("@dur", Dur);
            cmd4.Parameters.AddWithValue("@fee", fees);
            cmd4.Parameters.AddWithValue("@cid", cid);
            int res5 = cmd4.ExecuteNonQuery();
            if (res5 > 0)
            {
                Console.WriteLine("Course details Updated Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid Course details");
        }
        public void DeleteCourse()
        {
            try
            {
                con = getConnection();
                int cid;
                Console.WriteLine("Enter Course id:");
                cid = Convert.ToInt32(Console.ReadLine());
                cmd5 = new SqlCommand("delete Course where cid=@cid", con);
                cmd5.Parameters.AddWithValue("@cid", cid);
                int res6 = cmd5.ExecuteNonQuery();
                if (res6 > 0)
                {
                    Console.WriteLine("Row Deleted Sucessfully");
                }
                else
                    Console.WriteLine("please enter valid Course details");
            }
            catch (Exception e)
            {
                Console.WriteLine("You Cannot Delete this Course  Student already enrolled for this Course");
            }

        }
        public void EnrollCourse()
        {
            con = getConnection();
            int sid, cid;
            DateTime EnrollDate;
            Console.WriteLine("Enter the Student Id");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enterthe  Course Id");
            cid = Convert.ToInt32(Console.ReadLine());
            EnrollDate = DateTime.UtcNow;
            cmd8 = new SqlCommand("insert into EnrollCourse values(@Crs,@Std_id,@Enroll_date)", con);
            cmd8.Parameters.AddWithValue("@Crs", cid);
            cmd8.Parameters.AddWithValue("@std_id", sid);
            cmd8.Parameters.AddWithValue("@Enroll_date", EnrollDate);
            int res7 = cmd8.ExecuteNonQuery();
            if (res7 > 0)
            {
                Console.WriteLine("Student are  enrolled to the Course Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid details");
        }
        public void Particular_Student()
        {
            try
            {
                //Here we  retrieving particular student details
                con = getConnection();
                int sid;
                Console.WriteLine("Enter Student Id");
                sid = Convert.ToInt32(Console.ReadLine());
                cmd9 = new SqlCommand("select *from StudentDetails where Std_id=@Stud_id", con);
                cmd9.Parameters.AddWithValue("@Stu_id", sid);
                dr = cmd5.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Details : ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Student Id : " + " " + dr[0]);
                    Console.WriteLine("Student Name :" + " " + dr[1]);
                    Console.WriteLine("Student DOB :" + " " + dr[2]);
                    Console.WriteLine();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Students Doesn't Exist.....", e);
            }


        }
        public void Particular_Course()
        {
            
                try
                {
                    //Here we are retrieving particular Course details
                    con = getConnection();
                    int cid;
                    Console.WriteLine("Enter the Course Id");
                    cid = Convert.ToInt32(Console.ReadLine());
                    cmd = new SqlCommand("select *from Course where cid=@Cr_id", con);
                    cmd.Parameters.AddWithValue("@Cr_id", cid);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("Particular Course Details : ");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Course Id : " + " " + dr[0]);
                        Console.WriteLine("Course Name :" + " " + dr[1]);
                        Console.WriteLine("Course Duration :" + " " + dr[2]);
                        Console.WriteLine("Course Fees :" + " " + dr[3]);
                        Console.WriteLine();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Course Doesn't Exist...........!", e);
                }

            

        }
    }
}
