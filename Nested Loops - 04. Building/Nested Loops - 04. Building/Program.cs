

        //Write a program to print a table, representing a building:

        //· Reads two integer numbers from the console: floors count and estates count per floor

        //· Identifiers consist of: {type} {floor} {number}, e.g.L65, A12, O24

        //· Odd floors hold apartments (type A), e.g. A10, A11, A12, …

        //· Even floors hold offices (type O), e.g. O20, O21, O22, …

        //· The last floor holds large apartments (type L), e.g. L60, L61, L62

int floors = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());

for (int row = floors; row >= 1; row--) {


    for (int column = 0; column < estates; column++)
    {

        if (row == floors)
        {
            Console.Write($"L{row}{column} ");

        }

        else if (row % 2 == 0) //EVEN
        {
            Console.Write($"O{row}{column} ");
        }
        else //if (row % 2 != 0) //ODD
        {
            Console.Write($"A{row}{column} ");
        }
    }

    Console.WriteLine();
}