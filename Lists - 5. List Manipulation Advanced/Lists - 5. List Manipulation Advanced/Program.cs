namespace Lists___5._List_Manipulation_Advanced
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
                string operation = tokens[0]; // Here is the stored command only

                if (operation == "Contains")
                {
                    int item = int.Parse(tokens[1]);
                    Contains(numbers, item);
                }
                else if (operation == "PrintEven")
                {
                    PrintEven(numbers);
                }

                else if (operation == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if (operation == "GetSum")
                {
                    GetSum(numbers);
                }
                else if (operation == "Filter")
                {
                    string condition = tokens[1];
                    int number = int.Parse(tokens[2]);

                    if (condition == "<")
                    {
                        numbers.RemoveAll(x => x >= number);
                    }

                    if (condition == "<=")
                    {
                        numbers.RemoveAll(x => x > number);
                    }

                    if (condition == ">")
                    {
                       numbers.RemoveAll(x => x <= number);
                    }

                    if (condition == ">=")
                    {
                        numbers.RemoveAll(x => x < number);
                    }
                }
                Console.WriteLine(string.Join(" ", numbers));
            }

            static void Contains(List<int> numbers, int item)
            {

                if (numbers.Contains(item))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }

            static void PrintOdd(List<int> numbers)
            {
                List<int> oddNumbers = new List<int>();
                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        oddNumbers.Add(number);
                    }
                }
                Console.WriteLine(string.Join(" ", oddNumbers));
            }

            static void PrintEven(List<int> numbers)
            {
                List<int> evenNumbers = new List<int>();
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        evenNumbers.Add(number);
                    }
                }

                Console.WriteLine(string.Join(" ", evenNumbers));
            }
        }

        private static void GetSum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}