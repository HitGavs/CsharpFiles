using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class DateDemo
    {
        public static void FirstMethod()
        {
           

            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2020, 10, 10); //yyyy, mm, dd

            System.Console.WriteLine(d1.ToLongDateString()); //Month in words

            System.Console.WriteLine(d1.ToShortDateString()); //Month in numbers

            System.Console.WriteLine(d1.ToLongTimeString());  //Time with seconds  

            System.Console.WriteLine(d1.ToShortTimeString());//Time without seconds
        }
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        public static void ThirdMethod()
        {
            Console.WriteLine("enter the day (DOB) to enter into world");
            String strdob = String.Empty;
            try
            {
                Console.ReadLine();
                DateTime d1 = DateTime.Parse(strdob);
                DateTime d2 = DateTime.Now;
                TimeSpan ts = d2.Subtract(d1);
                DateTime age = new DateTime(ts.Ticks);
                Console.WriteLine("Age in Date" + age.ToShortDateString());
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
           
    }
}
