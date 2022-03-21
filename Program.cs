using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EmployeeManagement
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            InsertData();
        }
        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=JYOTHI-PC\\MSSQLSERVER01;initial catalog=EmployeeManagement;integrated security=true");
            con.Open();
            return con;
        }
        public static void InsertData()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter the Employee Details: ");
                string ename, etype;
                float esal;
                Console.WriteLine("Enter the Employee Name: ");
                ename = Console.ReadLine();
                Console.WriteLine("Enter the Employee Salary: ");
                esal = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Employee Type 'C' Or 'P':");
                etype = Console.ReadLine();
                cmd = new SqlCommand("execute dbo.Emp_Management @ename, @esal, @etype");
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@esal", esal);
                cmd.Parameters.AddWithValue("@etype", etype);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    Console.WriteLine("Number of Rows affected are : {0} ", no_ofrows);
                }
                else
                {
                    Console.WriteLine("Oh No !! Something is fishy");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }

        }
    }
    
}
