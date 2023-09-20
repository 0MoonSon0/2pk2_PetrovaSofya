namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double x, y, z;
            double result;

            if (a > Math.PI)
            {
                x = Math.Cos(a + 2 * c);
            }
            else
            {
                x = c + Math.Sqrt(a * (c * c) - 2 * (a + Math.PI));
            }

            if (x <= 0)
            {
                y = Math.Log(a + c - x);
            }
            else
            {
                y = Math.Sin(2 * a * x) + Math.Sin(a + x);
            }

            z = (2 * x + 3 * y) * (a * a - c * c);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            Console.ReadLine();
        }
    }
}