using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 1;
        double h = 0.2;

        Console.WriteLine("x\t\t y");

        while (x <= 3)
        {
            double y = 8 * x + Math.Pow(4 * x, 4) - Math.Pow(1.5 * x, 3);
            Console.WriteLine($"{x}\t\t {y}");

            x += h;
        }

        Console.ReadLine();
    }
}

