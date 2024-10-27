using System.ComponentModel;

namespace Loops___06._Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Write a program to check if given number is special:
            //· Special numbers are divisible by all of their digits without remainder
            //· Reads an integer number and check whether it is a special number
            //· If the number IS special print: "{num} is special"
            //· If the number is NOT special print: "{num} is not special"
            //Note: There will not be numbers with digit 0 in them.

            int number = int.Parse(Console.ReadLine());

            int numberCopy = number;

            bool isSpecial = false;

            while (numberCopy > 0)
            {
                int lastDigit = numberCopy % 10;
             
                if (number % lastDigit == 0)
                {
                    isSpecial = true;
            //        Console.WriteLine($"{numberCopy} is special");
                }
                else //if (numberCopy % lastDigit != 0)
                {
                    isSpecial = false;
                //    Console.WriteLine($"{numberCopy} is not special");
                    break;
                }
                numberCopy = numberCopy / 10;
            }

            if (isSpecial)
            {
                Console.WriteLine($"{number} is special");
            }
            else
            {
                Console.WriteLine($"{number} is not special");

            }

        }
    }
}
