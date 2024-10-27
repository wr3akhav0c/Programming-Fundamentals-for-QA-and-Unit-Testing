using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

                //            Write a program to find statistics about division to 2, 3 and 4:

                //· Read an integer number N and N integers from the console
                //· Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4
                //· Print the percentages, formatted to the second decimal digit:
                //o On the first line print percent of the numbers that are divisible by 2
                //o On the first line print percent of the numbers that are divisible by 3
                //o On the first line print percent of the numbers that are divisible by 4

            int N = int.Parse(Console.ReadLine());

            int divisionBy2 = 0;
            int divisionBy3 = 0;
            int divisionBy4 = 0;

            for (int i = 0; i < N; i++)
            {

                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    divisionBy2++;
                }

                if (number % 3 == 0)
                {
                    divisionBy3++;
                }

                if (number % 4 == 0)
                {
                    divisionBy4++;
                }

            }

            double percentBy2 = (double)divisionBy2 / N * 100;
            double percentBy3 = (double)divisionBy3 / N * 100;
            double percentBy4 = (double)divisionBy4 / N * 100;

            Console.WriteLine($"{percentBy2:F2}%");
            Console.WriteLine($"{percentBy3:F2}%");
            Console.WriteLine($"{percentBy4:F2}%");

        }
    }

}