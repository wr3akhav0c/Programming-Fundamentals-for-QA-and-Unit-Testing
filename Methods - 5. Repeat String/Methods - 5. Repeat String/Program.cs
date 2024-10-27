namespace Methods___5._Repeat_String
{
    internal class Program
    {
        static void Main()
        {
           string text = Console.ReadLine();
           int count = int.Parse(Console.ReadLine());
                
           string output = Repeater(text, count);
           Console.WriteLine(output);

        }

        static string Repeater(string text, int count)
        {
            string result = "";
            for (int i = 1; i <= count; i++)
            {
                result += text;
            }

            return result; 
        }
    }
}
