using System.ComponentModel;
using System.Drawing;

namespace Methods___04._Calculate_Rectangle_Area
{
    internal class Program
    {
        // Write a program that:
        //· Reads two integer numbers from the console: width and length
        //· Create a method which returns rectangle area with given width and length
        //Hint: Rectangle area can be calculated when you multiply width and length of the rectangle.

        static void Main()
        {
            double result = CalcRectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }

        public static double CalcRectangleArea(double a, double b)
        {
            double area = a * b;
            return area;           
        }
    }
}
