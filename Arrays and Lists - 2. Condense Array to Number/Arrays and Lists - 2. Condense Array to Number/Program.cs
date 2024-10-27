namespace Arrays_and_Lists___2._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condensedArray = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++) 
                {
                    int sumNums = numbers[i] + numbers[i + 1];
                    condensedArray[i] = sumNums;                    
                }

                numbers = condensedArray;
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
