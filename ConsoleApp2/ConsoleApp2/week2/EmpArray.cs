using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.week2
{
    internal class EmpArray
    {
        public static void SortingArrays()

        {

            int[] nos = { 32, 21, 10, 56, 87, 43, 97, 2 };

            Console.WriteLine("B4 sort ");

            int len = nos.Length;

            for (int i = 0; i < len; i++)

            {

                Console.Write(nos[i] + ",");

            }

            Console.WriteLine();

            Array.Sort(nos);

            Console.WriteLine("After sort ");



            len = nos.Length;

            for (int i = 0; i < len; i++)

            {

                Console.Write(nos[i] + ",");

            }

            Console.WriteLine();



        }

        class Emp

        {

            private readonly double Id;

            public string Name;

            public string FirstName { get; set; }

            public string MiddleName { get; set; }

            public string LastName { get; set; }

            public double Salary { get; set; }

            public Emp() { }

            public Emp(double v1)

            {

                Id = v1;

            }

            public double GetID()

            {

                return Id;

            }

        }
    }
}
