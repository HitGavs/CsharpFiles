/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hit1.DayOne
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int n = 9; //Number of rows

            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--) //decreasing order
                {
                    Console.Write(j);
                }
                for (int j = 2; j <= i; j++) //increasing order
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }
    }
}

*/