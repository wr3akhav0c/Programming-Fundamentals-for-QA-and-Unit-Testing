namespace Arrays_and_Lists___3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> output = new List<int>();

            int iterations = 0;

            if (firstList.Count > secondList.Count)
                iterations = firstList.Count;
            else iterations = secondList.Count;

            for (int i = 0; i < iterations; i++)
            {
                if (i < firstList.Count)
                {
                    int elementFirstList = firstList[i];
                    output.Add(elementFirstList);
                }

                if (i < secondList.Count)
                {
                    int elementSecondList = secondList[i];
                    output.Add(elementSecondList);
                }
            }

            Console.WriteLine(string.Join(" ", output));

        }
    }
}
