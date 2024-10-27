namespace Methods___07._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());          
                Console.WriteLine(CompareInts(a, b));
            }
            else if (type == "char") 
            { 
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(CompareChars(a, b));
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(CompareStrings(a, b));
            }          
        }

        static int CompareInts(int a, int b) 
        {
            int biggerNumber = 0;
            if (a < b)
            {                
                biggerNumber = b;
            }
            else if (a > b)
            {
                biggerNumber = a;
            }
            return biggerNumber;
        }

        static char CompareChars(char a, char b)
        {
            char biggerChar = a;

            if (a < b)
            {
                biggerChar = b;
            }

            return biggerChar;
        }

        static string CompareStrings(string a, string b)
        {
            int biggerString = a.CompareTo(b);
            if (biggerString >= 0)
            {
                return a;
            }
            else 
            {
                return b;
            }          
        }
    }
}
