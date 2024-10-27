namespace _2._Average_Stock_Price_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> stockPrices = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<double> newStockPrices = new List<double>();
            double sum = 0;
            double values = 0;

            //newStockPrices = stockPrices.Take(endNumber).ToList();
            //Console.WriteLine(string.Join(" ", newStockPrices));

            //int startIndex = stockPrices[startNumber];
            //int endIndex = stockPrices[endNumber];

            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += stockPrices[i];
            }

            double average = sum / (endNumber - startNumber + 1);

            Console.WriteLine($"{average:F2}");

        }
    }
}
