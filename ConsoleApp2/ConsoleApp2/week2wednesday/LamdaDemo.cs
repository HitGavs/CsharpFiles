using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.week2wednesday
{
    internal class LamdaDemo
    {
        public static void DemoA()
        {
            Func<int, int> foo = x => x / 2;
            /*first int is Input Value and second int was Output value*/
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }





        public static void DemoB()
        {
            Func<int> foo = () => 100;
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC()
        {
            Func<double, double, double> callme = (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 10;
            double result = callme(v1, v2);
            Console.WriteLine(result);
        }
        public static void DemoD()
        {
            Func<int, double> foo = x => (double)x / 2;
            int v1 = 101;
            double result = foo(v1);
            Console.WriteLine(result);
        }
        public static void DemoE()
        {



        }
        public static void DemoF()
        {
            Func<double, int> foo = x => (int)x / 2;
            int v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }
        static void Echo(Func<String>foo)
        {
            String str = foo();
            Console.WriteLine(str);
        }
        static void TestEcho()
        {
            Echo(() => "hello");
            Echo(() => "Worlde");

        }
    }
}

