namespace _8._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int product = a * b * c;

            if (product == 0)
            {
                Console.WriteLine("zero");
            }
            else if (product > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
