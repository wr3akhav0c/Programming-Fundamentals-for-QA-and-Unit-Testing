namespace ExamPrep1_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // int[] = { 1, 2, 3, 4 } --> Length=4 / 2 = index 2

            int secondIndex = numbers.Length / 2;
            int secondNumber = numbers[secondIndex];
            int firstNumber = numbers[secondIndex - 1];

            int sum = firstNumber + secondNumber;
            double average = sum / 2.0;

            Console.WriteLine($"{average:F2}");

        }
    }
}
