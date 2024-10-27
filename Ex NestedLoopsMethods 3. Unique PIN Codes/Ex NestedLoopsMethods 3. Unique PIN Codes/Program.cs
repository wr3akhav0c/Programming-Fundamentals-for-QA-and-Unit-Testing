using System.Collections.Generic;
using System.ComponentModel;

namespace Ex_NestedLoopsMethods_3._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to generate PIN codes following certain rules:

            //· Read 3 integer digits: max1, max2, max3(each is an upper limit)
            //· Generate unique 3 - digit PIN codes, matching the following:
            //o Each digit is within the following range:
            //ü First digit: [1 … max1]
            //ü Second digit: [1 … max2]
            //ü Third digit: [1 … max3]
            //o The first and the third digit must be even
            //o The second digit must be a prime number in the range[2…7]
            //· Print the PIN codes, each on separate line

            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());

            for (int first = 1; first <= max1; first++)
            {
                for (int second = 1; second <= max2; second++)
                {
                    for(int third = 1; third <= max3; third++)
                    {
                        if (first % 2 == 0 && third % 2 == 0)
                        {
                            if (second == 2 || second == 3 || second == 5 || second == 7) 
                            {
                                Console.WriteLine($"{first}{second}{third}");
                            }
                        }
                    }
                }
            }


        }
    }
}
