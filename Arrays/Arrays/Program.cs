namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
                Console.WriteLine("You added " + numbers[index] + " to the array");
            }

            
        }
    }
}
