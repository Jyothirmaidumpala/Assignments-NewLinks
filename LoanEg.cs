using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement3
{
    class LoanProcessException : ApplicationException
    {
        public LoanProcessException(string msg) : base(msg)
        {

        }
    }

    class Loan
    {
        int Loan_no;
        string Cust_name;
        double EMI_Amount;
        double LoanAmount;
        double AccBal;

        public Loan(int ln, string cname, double ab)
        {
            Loan_no = ln;
            Cust_name = cname;
            AccBal = ab;
            Console.WriteLine("Loan Number:{0)\nCustomer name:{1}\nAccount Balance{2}", Loan_no, Cust_name, AccBal)
        }
        public void Calculate_EMI()
        {
            Console.WriteLine("Enter Loan Amount:");
            LoanAmount = Convert.ToDouble(Console.ReadLine());
            EMI_Amount = LoanAmount * 0.13 * 3;
            Console.WriteLine("EMI AMount={0}", EMI_Amount);
        }
        public void CheckBal()
        {
            if (AccBal < EMI_Amount)
            {
                throw (new LoanProcessException("The Balance is not sufficeinet to Repay Loan"));
            }
            else
            {
                Console.WriteLine("Loan Process Successfully Completed");
            }
        }
    }
    class LoanEg
    {
        static void Main()
        {
            LoanProcessException lpe = new LoanProcessException(8907503, "Jyothi", 45000);
            lpe.Calculate_EMI();
            try
            {
                lpe.CheckBal();
            }
            catch (LoanProcessException e)
            {
                Console.WriteLine(e.message);
            }
        }
    }
}


