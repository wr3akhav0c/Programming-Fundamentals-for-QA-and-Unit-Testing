using System;

class Program
{
    static void Main()
    {
        // Read the number of floors from the console
        Console.Write("Enter the number of floors: ");
        int floorsCount = int.Parse(Console.ReadLine());

        // Read the number of estates per floor from the console
        Console.Write("Enter the number of estates per floor: ");
        int estatesCountPerFloor = int.Parse(Console.ReadLine());

        // Loop through each floor
        for (int floor = floorsCount; floor >= 1; floor--)
        {
            // Loop through each estate on the current floor
            for (int estateNumber = 0; estateNumber < estatesCountPerFloor; estateNumber++)
            {
                // Determine the type of estate
                string estateType;

                if (floor == floorsCount)
                {
                    // Last floor holds large apartments
                    estateType = "L";
                }
                else if (floor % 2 == 0)
                {
                    // Even floors hold offices
                    estateType = "O";
                }
                else
                {
                    // Odd floors hold apartments
                    estateType = "A";
                }

                // Print the identifier
                Console.Write($"{estateType}{floor}{estateNumber} ");
            }

            // Move to the next line after printing all estates on the current floor
            Console.WriteLine();
        }
    }
}
