namespace _1._Nutrition_and_Caloric_Intake_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int calories = 0;
            int cumulativeIntake = 0;
            List<int> cumulativesSum = new List<int>();

            if (n < 0 || n==0)
            {
                Console.WriteLine("0");
            }

            while (n > 0)
            {
                calories = int.Parse(Console.ReadLine());

                cumulativeIntake += calories;
                cumulativesSum.Add(cumulativeIntake);
                n--;
             

            }
            //Console.WriteLine(String.Join("\n ", cumulativesSum.ToArray()));
            foreach (int sum in cumulativesSum) {
                Console.WriteLine(sum);
            }

            

        }
    }
}
