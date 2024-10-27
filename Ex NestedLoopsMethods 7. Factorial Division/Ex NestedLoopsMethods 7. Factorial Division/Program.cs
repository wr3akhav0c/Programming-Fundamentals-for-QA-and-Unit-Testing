using System;

namespace Ex_NestedLoopsMethods_7._Factorial_Division
{
    internal class Program
    {
        static void Main()
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());

           int firstFactorial = (GetFactorial(a));
           int secondFactorial = (GetFactorial(b));

           Console.WriteLine(firstFactorial/secondFactorial);
        }

        public static int GetFactorial(int number)
        {
            int factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial = i * factorial;
            }
            return factorial;
        }
    }
}
