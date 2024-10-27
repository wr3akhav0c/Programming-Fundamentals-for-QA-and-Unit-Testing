namespace Arrays___6._Common_Elements
{
    internal class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            foreach (int item in firstArray)
            {
                foreach (int number in secondArray)
                {
                    if (item == number)
                    {
                        Console.Write($"{item} ");
                        break;
                    }
                }
            }
        }
    }
}
