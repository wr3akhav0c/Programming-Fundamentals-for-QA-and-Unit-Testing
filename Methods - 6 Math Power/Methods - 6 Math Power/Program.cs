namespace Methods___6_Math_Power
{
    internal class Program
    {
        static void Main()
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            MathPower(baseNumber, power);            

        }

        public static int MathPower(int baseNumber, int power)
        {
            int result = (int)Math.Pow(baseNumber, power);
            Console.WriteLine(result);
            return result;
        }
    }
}
