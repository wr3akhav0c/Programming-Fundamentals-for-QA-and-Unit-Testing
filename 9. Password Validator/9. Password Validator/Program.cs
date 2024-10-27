using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;

namespace _9._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            // The password validation rules are:

            //· It should contain 6 – 10 characters(inclusive)
            //· It should contain only letters and digits
            //· It should contain at least 2 digits

            if (CheckPassBetween6And10(password) == false)
            {            
                Console.WriteLine("Password must be between 6 and 10 characters");                
            }

            if (LettersAndDigitsOnly(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (ConsistsMin2Digits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckPassBetween6And10(password)  && LettersAndDigitsOnly(password) && ConsistsMin2Digits(password))
            {
                Console.WriteLine("Password is valid");
            }

            //If it is not valid, for any unfulfilled rule print the corresponding message:

            //· "Password must be between 6 and 10 characters"
            //· "Password must consist only of letters and digits"
            //· "Password must have at least 2 digits"            
        }

        static bool CheckPassBetween6And10(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }
            return false;
        }

        static bool LettersAndDigitsOnly(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                char currentChar = pass[i];

                if (!char.IsLetterOrDigit(currentChar))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ConsistsMin2Digits(string pass)
        {
            int counter = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                char currentChar = pass[i];

                if (char.IsDigit(currentChar))
                {
                    counter++;

                    if (counter == 2)
                    {
                        return true;                        
                    }
                }
            }

            return false;
        }
    }
}