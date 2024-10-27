using System.ComponentModel;
using System.Drawing;
using System;

namespace Methods___02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Write a program that:
            //· Reads a grade(floating - point number) from the console
            //· Create a method that receives a grade between 2.00 and 6.00
            //· Prints the corresponding grade in words
            //o "Fail" - If the grade is in range 2.00 – 2.99(inclusively)
            //o "Average" - If the grade is in range 3.00 – 3.49(inclusively)
            //o "Good" - If the grade is in range 3.50 – 4.49(inclusively)
            //o "Very good" - If the grade is in range 4.50 – 5.49(inclusively)
            //o "Excellent" - If the grade is in range 5.50 – 6.00(inclusively)

            double grade = double.Parse(Console.ReadLine());
            Grades(grade);


            static void Grades(double grade)
            {

                switch (grade)
                {
                    case >= 2 and <= 2.99:
                        Console.WriteLine("Fail");
                        break;

                    case >= 3.00 and <= 3.49:
                        Console.WriteLine("Average");
                        break;

                    case >= 3.50 and <= 4.49:
                        Console.WriteLine("Good");
                        break;

                    case >= 4.50 and <= 5.49:
                        Console.WriteLine("Very good");
                        break;              

                    default:
                        Console.WriteLine("Excellent");
                        break;
                }


                //   if (grade >= 2.00 && grade <= 2.99)
                //    {
                //        Console.WriteLine("Fail");
                //    }
                //   else if (grade >= 3.00 && grade <= 3.49)
                //    {
                //        Console.WriteLine("Average");
                //    }
                //    else if (grade >= 3.50 && grade <= 4.49)
                //    {
                //        Console.WriteLine("Good");
                //    }
                //    else if (grade >= 4.50 && grade <= 5.49)
                //    {
                //        Console.WriteLine("Very good");
                //    }
                //    else //(grade >= 5.50 || grade <= 6.00)
                //    {
                //        Console.WriteLine("Excellent");
                //    }                          
            }


        }
    }
}
