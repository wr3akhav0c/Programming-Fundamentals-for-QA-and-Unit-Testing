﻿namespace Exercise___Nested_Loops_Methods___Stupid_Passwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            for (int firstDigit = 2; firstDigit <= number; firstDigit += 2) 
            {
                for (int secondDigit = 1; secondDigit <= number; secondDigit += 2)
                {
                    int thirdDigit = firstDigit * secondDigit;
                    Console.Write($"{firstDigit}{secondDigit}{thirdDigit} ");
                }
            }        
        }
    }
}
