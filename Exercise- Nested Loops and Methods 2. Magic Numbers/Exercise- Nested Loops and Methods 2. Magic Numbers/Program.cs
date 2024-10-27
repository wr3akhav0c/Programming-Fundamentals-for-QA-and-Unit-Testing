namespace Exercise__Nested_Loops_and_Methods_2._Magic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++) 
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 1; third <= n; third++)
                    {
                        if (first >= 10 || second >= 10 || third >= 10)
                        {
                            continue;  //If one of the numbers is >=10, start the for from beginning
                        }

                        int product = first * second * third;

                        if (product == n)
                        {
                        
                            Console.Write($"{first}{second}{third} ");
                        
                        }                                                
                    }
                }
            }
        }
    }
}
