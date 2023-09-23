//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hit1.DayTwo
//{
//    internal class Appointment
//    {
//        public String Name { get; set; }

//        public String Title{ get; set; }
//        public DateTime Date { get; set; }
//        public String Location { get; set; }

//        public Appointment(string name, String title,  DateTime date, String location )
//        {
//            Name = name;
//            Title = title;
//            Date = date;
//            Location = location;
            
//        }
//        public void DisplayDetails()
//        {
//            Console.WriteLine($"Name: {Name}");
//            Console.WriteLine($"Title: {Title}");
//            Console.WriteLine($"Date: {Date}");
//            Console.WriteLine($"Location: {Location}");
//        }
//    }
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Appointment myAppointment = new Appointment("Hitesh", "meeting", DateTime.Now,  "Conference Room");

//            myAppointment.DisplayDetails();
//        }
//    }
//}
