namespace Arrays___5._Equal_Arrays
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

            for (int index = 0; index < firstArray.Length; index++)
            {
                int firstArrayCurrentEl = firstArray[index];
                int secondArrayCurrentEl = secondArray[index];

                if (firstArrayCurrentEl != secondArrayCurrentEl)
                { 
                Console.WriteLine("Arrays are not identical.");
                return;
                }
               
            }

            Console.WriteLine("Arrays are identical.");

        }
    }
}
