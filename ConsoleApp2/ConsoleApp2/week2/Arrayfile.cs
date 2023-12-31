﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.week2
{
    internal class Arrayfile
    {
        public static void FirstMethod()
        {

            int[] sample = new int[10];
            int length = sample.Length;
            int i;
            Random random = new Random();
            for (i = 0; i < 10; i = i + 1)
                sample[i] = random.Next(100);
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            Console.WriteLine("Sum:" + sample.Sum());
            Console.WriteLine("Average:" + sample.Average());
            Console.WriteLine("Max " + sample.Max());
            Console.WriteLine("Max " + sample.Min());


        }

        public static void UsingJaggedArrays()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
            int i;
            // Store values in first array.
            for (i = 0; i < 4; i++)
                jagged[0][i] = i;
            // Store values in second array.
            for (i = 0; i < 3; i++)
                jagged[1][i] = i;
            // Store values in third array.
            for (i = 0; i < 5; i++)
                jagged[2][i] = i;
            // Display values in first array.
            for (i = 0; i < 4; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            // Display values in second array.
            for (i = 0; i < 3; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            // Display values in third array.
            for (i = 0; i < 5; i++)
                Console.Write(jagged[2][i] + " ");
            Console.WriteLine();
        }


    }

}
