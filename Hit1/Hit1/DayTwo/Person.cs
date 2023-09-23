//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hit1.DayTwo
//{
//    internal class Person
//    {
//         public int Id { get; set; }
//        public String FirstName { get; set; } = string.Empty;
//        public String LastName { get; set; } = string.Empty;
//        public String Title { get; set; } = string.Empty;
//        public String Address { get; set; } = string.Empty;
//        public String City { get; set; } = string.Empty;
//        public String Region { get; set; } = string.Empty;
//        public String PostalCode { get; set; } = string.Empty;
//        public String Country { get; set; } = String.Empty;
//        public long Phone { get; set; }

//        public override string ToString()
//        {
//            return $"ID:{this.Id}, Name:{Title} {FirstName} {LastName},\n" +
//                $"Address:{Address}, City:{City}, State:{Region},\n" +
//                $"Phone:{Phone}, Country:{Country}, Zip:{PostalCode},\n";
//        }
//    }
//    internal class TestPerson
//    {
//        public static void TestOne()
//        {
//            Person firstPerson = new Person();
//            firstPerson.Id = 1;
//            firstPerson.FirstName = "hitesh";
//            firstPerson.LastName = "M";
//            firstPerson.Address = "lalacheruvu housing board";
//            firstPerson.City = "rajamundry";
//            firstPerson.Region = "east godavari";
//            firstPerson.PostalCode = "533242";
//            firstPerson.Country = "INDIA";
//            firstPerson.Phone = 8919251756L;
//            String Value = firstPerson.ToString();
//            Console.WriteLine(Value);


//        }
//    }
//}
