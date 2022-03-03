using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Account
    {
        long AccountNo;
        string CustomerName;
        string AccountType;
        float balance = 30000;
        public Account(long accno, string name, string acctype)
        {
            AccountNo = accno;
            CustomerName = name;
            AccountType = acctype;
        }
        public void Transactiontype()
        {
            Console.WriteLine("Enter the Transaction Type:D or d");
            var transtype = Convert.ToChar(Console.ReadLine());
            if (transtype == 'D' || transtype == 'd')
            {
                Credit(20000);
            }
            else
            {
                Debit(10000);
            }
        }
        public void Credit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Available Balance After deposit is:{0}\nCustomerName:{1}", balance, CustomerName);
            Console.WriteLine("Available Balance is:{0}", balance);
        }
        public void Debit(int amt)
        {
            balance = balance - amt;
            Console.WriteLine("Available Balance After WithDrawl is:{0}\nCustomerName:{1}", balance, CustomerName);
            Console.WriteLine("Available Balance is:{0}", balance);
        }
        public void ShowDetails()
        {
            Console.WriteLine("Enter Account Holder Details");
            Console.WriteLine("Account Number:{0}\nCustomerName:{1}\nAccountType:{2}", AccountNo, CustomerName, AccountType);
            Console.WriteLine("Available Balance is:{0}", balance);
            Transactiontype();
        }
        static void Main()
        {
            Account ac = new Account(23456788888, "Jyothi", "Savings");
            ac.ShowDetails();
        }
    }
}
    



