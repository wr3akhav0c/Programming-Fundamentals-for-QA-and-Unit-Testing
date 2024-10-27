using System.Runtime.ExceptionServices;

namespace Arrays_and_Lists___8._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int rotations = int.Parse(Console.ReadLine());
            int firstElement = sequence[0];

            for (int i = 0; i < rotations; i++)
            {
                sequence.RemoveAt(0);
                sequence.Add(firstElement);
                firstElement = sequence[0];
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
