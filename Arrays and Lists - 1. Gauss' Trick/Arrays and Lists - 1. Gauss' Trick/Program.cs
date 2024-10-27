namespace Arrays_and_Lists___1._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List <int> list = Console.ReadLine ().Split(" ").Select(int.Parse).ToList();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            List <int> output = new List <int>();

            int iterations = numbers.Length / 2;

            for (int i = 0; i < iterations; i++)
            {
                int currentNum = numbers[i] + numbers[numbers.Length - 1 - i];
                output.Add(currentNum);
            }

            if (numbers.Length % 2 != 0)
            {
                int index = numbers.Length / 2;
                output.Add(numbers[index]);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
