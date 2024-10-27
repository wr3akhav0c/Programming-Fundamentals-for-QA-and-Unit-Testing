namespace Methods___8._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = Math.Abs(int.Parse(Console.ReadLine()));
           int result = GetMultipleOfEvenAndOdds(number);
           Console.WriteLine(result);

        }
           
        static int GetSumOfEvenDigits(int number)       // 2, 4, 6, 8
        {
            int sum = 0;

            while (number > 0) 
            { 
                int digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)       // 1, 3, 5, 7
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

    }
}
