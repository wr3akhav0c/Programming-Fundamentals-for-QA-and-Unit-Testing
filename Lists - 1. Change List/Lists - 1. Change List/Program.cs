namespace Lists___1._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] parts = command.Split(" ");
                string operation = parts[0];

                if (operation == "Delete")
                {
                    DeleteOperation(numbers, parts);
                }
                else if (operation == "Insert")
                {
                    InsertOperation(numbers, parts);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void InsertOperation(List<int> numbers, string[] parts)
        {
            int index = int.Parse(parts[2]);
            int elementForInsertion = int.Parse(parts[1]);
            numbers.Insert(index, elementForInsertion);
        }

        private static void DeleteOperation(List<int> numbers, string[] parts)
        {
            int elementForRemoval = int.Parse(parts[1]);
            while (numbers.Contains(elementForRemoval))
            {
                numbers.Remove(elementForRemoval);
            }
        }
    }
}
