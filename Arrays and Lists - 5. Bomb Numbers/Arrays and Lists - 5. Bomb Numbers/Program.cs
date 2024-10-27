namespace Arrays_and_Lists___5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();                  

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                        startIndex = 0;

                    if (endIndex > numbers.Count - 1)
                        endIndex = numbers.Count - 1;

                    int countToRemove = endIndex - startIndex + 1;

                    numbers.RemoveRange(startIndex, countToRemove);
                    i = startIndex - 1;
                }
            }           
            Console.WriteLine(numbers.Sum());
        }
    }
}
