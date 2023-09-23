using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.week2wednesday
{
    internal class BankTest
    {
        public readonly int BankID;
        public readonly string BankName;
        public  string AccountType;
        public readonly string Branch;  
    }
    internal class Customer
    {
        public readonly int AccountNo;
        public readonly int IfscNo;
        public  string CustomerName;
        public readonly string Address;


    }
    internal enum AccountType 
    {
       Savings,
       Current,
    }
    internal class Transaction 
    {


    }
    

}
