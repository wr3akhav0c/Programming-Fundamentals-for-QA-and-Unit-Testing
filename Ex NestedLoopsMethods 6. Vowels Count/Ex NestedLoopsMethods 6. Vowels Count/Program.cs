using static System.Net.Mime.MediaTypeNames;

namespace Ex_NestedLoopsMethods_6._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(ReceiveText(text));
        }
        // vowels = a, e, i, o, u, y
        static string ReceiveText(string text)
        {

            int total = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar == 'y')
                {
                    total++;
                }
            }
            return total.ToString();

        }

    } 
}
