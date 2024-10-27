namespace Lists___4._List_Manipulation_Basics
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
                string[] tokens = command.Split(" "); //Add 5
                string operation = tokens[0]; //Add
                if (operation == "Add") // Add {number}
                {
                    int item = int.Parse(tokens[1]);
                    numbers.Add(item);
                }
                else if (operation == "Remove") // Remove {number}
                {
                    int item = int.Parse(tokens[1]);
                    numbers.Remove(item);
                }
                else if (operation == "RemoveAt") //RemoveAt {index}
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (operation == "Insert") //Insert {number} {index}
                {
                    int item = int.Parse (tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, item);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
