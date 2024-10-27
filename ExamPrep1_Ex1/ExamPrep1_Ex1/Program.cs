namespace ExamPrep1_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

 //                 Console.WriteLine("Factoriel of 2: " + GetFactorial(2));
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            while (numbers > 0)
            {          //Taking the last digit
                int lastDigit = numbers % 10;
                numbers = numbers / 10;
 //                 Console.WriteLine($"Last digit {lastDigit}");

                if (lastDigit % 2 == 0)
                {
 //                 Console.WriteLine("Factoriel of " + lastDigit + " is " + GetFactorial(lastDigit));
                    sum += GetFactorial(lastDigit);
 //                 Console.WriteLine("Get factorial of last digit: " + lastDigit);                                                        
                }            
            }

            Console.WriteLine(sum);

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
