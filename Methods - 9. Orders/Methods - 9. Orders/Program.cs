namespace Methods___9._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine(); // "coffee", "water", "coke" or "snacks"
            int quantity = int.Parse(Console.ReadLine());            
            Console.WriteLine($"{TotalPrice(product, quantity):F2}");
        }

        public static double TotalPrice(string product, int quantity)
        {
            //Price list
            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;           
            
            switch (product)
            {
                case "coffee":
                double coffeePrice = coffee * quantity;
                return coffeePrice;

                case "water":
                double waterPrice = water * quantity;
                return waterPrice;

                case "coke":
                double cokePrice = coke * quantity;
                return cokePrice;              

                default:
                double snacksPrice = snacks * quantity;
                return snacksPrice; ;
            }

        }
    }
}
