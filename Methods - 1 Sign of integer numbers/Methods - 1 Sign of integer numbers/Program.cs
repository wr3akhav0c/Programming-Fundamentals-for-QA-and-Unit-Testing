namespace Methods___1_Sign_of_integer_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckNumber();
            CheckNumber();
            CheckNumber();
            CheckNumber();
            CheckNumber();


            static void CheckNumber()
            {
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
                else if (number < 0)                 
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is zero.");
                }               
            }

           



            //        · Reads an integer number N from the console
            //· Create a method that prints the sign of an entered number N:
            //· Print:

            //o If the number is positive(N > 0) : "The number {number} is positive."
            //o If the number is negative(N< 0) : "The number {number} is negative."
            //o If the number is zero(N = 0) : "The number {number} is zero."

        }

    }
}
