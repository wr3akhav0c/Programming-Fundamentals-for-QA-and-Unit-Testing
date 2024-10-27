    //Write a program that calculate the money collection for multiple travel destinations:

    //· Read a destination (string) and needed budget (floating-point number) for the destination
    //· Read many times amounts of collected money, until they are enough for the destination (starting from 0)

    //o Print:
    //"Collected: {sum}" where sum is formatted to 2nd digit
    //or
    //"Going to {destination}!"

    //· Read another destination and budget and collect money again
    //· A destination "End" ends the program

    string destination = Console.ReadLine();
    double budget = double.Parse(Console.ReadLine());
    double sum = 0;

    //if (destination == "End") { break; }
    //Console.WriteLine("sled tova vlizam v while");

    while (destination != "End")
    {
       
        double collectedAmount = double.Parse(Console.ReadLine());
        sum += collectedAmount;
        Console.WriteLine($"Collected: {sum:F2}");


        if (sum >= budget)
        {
            Console.WriteLine($"Going to {destination:F2}!");

            destination = "";
            budget = 0;
            sum = 0;
        //Console.WriteLine("Resetnala sum destinacii i budget");

        destination = Console.ReadLine();
        if (destination == "End")
        {
            break;
        }
            budget = double.Parse(Console.ReadLine());
                   
        }
    
    }
