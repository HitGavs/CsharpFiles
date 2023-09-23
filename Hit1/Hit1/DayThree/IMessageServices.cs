//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hit1.DayThree
//{
//    internal interface IMessageServices
//    {
//        void SendMessage(string message);
//        void SendAudioMessage(string message);

//        void SendVideoMessage(string message);

//        void RecivedMessage();
//        void DeleteMessage();
//    }
//    internal class WhatsApp : IMessageServices
//    {
//        public void DeleteMessage()
//        {
//            Console.WriteLine("Method Not Implemented");
//        }
//        public void SendAudioMessage(string message)
//        {
//            Console.WriteLine("Method Not Implemented");
//        }
//        public void SendMessage(string message)
//        {
//            Console.WriteLine("Method Not Implemented");
//        }
//        public void SendVideoMessage(string message)
//        {
//            Console.WriteLine("Method Not Implemented");
//        }
//    }

//    public class MessageTester 
//    {
//      public void TestOn()    
//        {
//            IMessageServices messageServices = new WhatsApp();
//            messageServices.SendMessage("Hello");
//            messageServices.RecivedMessage();
//        }
//        public void TesttTwo()
//        {

//        }
//    }
//}
