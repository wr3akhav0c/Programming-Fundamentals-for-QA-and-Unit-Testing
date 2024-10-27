namespace Ex_NestedLoopsMethods_4._Letter_Combinations
{
    internal class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char excluded = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = start; i <= end; i++)
            {
                if (i == excluded) continue;

                for (char j = start; j <= end; j++)
                {
                    if (j == excluded) continue;

                    for (char k = start; k <= end; k++)
                    {
                        if (k == excluded) continue;

                        Console.Write($"{i}{j}{k} ");
                        count++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}
