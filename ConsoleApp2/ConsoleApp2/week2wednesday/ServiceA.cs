using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.week2wednesday
{
    internal class ServiceA
    {
            int x = 0;
            public void DoTaskA()
            {
                Monitor.Enter(this);
                Thread t1 = Thread.CurrentThread;
                int id = t1.ManagedThreadId;
                Console.WriteLine("Inside doTaskA");
                Console.WriteLine("\t Thread ID: " + id);
                //int x = 0;              //Local Variable


                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ":X=" + x + "icount=" + icount);
                    Thread.Sleep(1000);
                }

            }
            static void DemoA()
            {
                Thread t = Thread.CurrentThread;
                int id = t.ManagedThreadId;
                Console.WriteLine("Main Th ID" + id);
                ServiceA a1 = new ServiceA();
                a1.DoTaskA();
            }
            //Multiple Threads
            public static void DemoB()
            {
                Thread t = Thread.CurrentThread;
                int id = t.ManagedThreadId;
                Console.WriteLine("MainTh ID" + id);
                ServiceA a1 = new ServiceA();
                Thread t1 = new Thread(a1.DoTaskA);       //Delegate
                t1.Start();
                a1.DoTaskA();
                Console.WriteLine("-------End of DemoB-----");
            }
            public static void DemoB2()
            {
                Thread t = Thread.CurrentThread;
                int id = t.ManagedThreadId;
                Console.WriteLine("MainTh ID" + id);
                ServiceA a1 = new ServiceA();
                Thread t1 = new Thread(a1.DoTaskA);       //Delegate
                Console.WriteLine(t1.ManagedThreadId + "T1 State" + t1.ThreadState);
                t1.Start();
                Console.WriteLine(t1.ManagedThreadId + "State After Start" + t1.ThreadState);
                Thread.Sleep(6000);
                Console.WriteLine(t1.ManagedThreadId + "T1 State After Sleep" + t1.ThreadState);
                Console.WriteLine("-------End of DemoB-----");
            }



        
    }
}
