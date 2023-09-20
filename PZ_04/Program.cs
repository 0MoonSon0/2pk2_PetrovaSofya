namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            int rangeStart = 10;
            int rangeEnd = 60;
            int step = 3;
            Console.WriteLine("Задание 1:");
            for (int i = rangeStart; i <= rangeEnd; i += step)
            {
                Console.WriteLine(i);
            }

            // Задание 2
            int n = 28;
            char startChar = 'Д';
            for (int i = 0; i < n; i++)
            {
                Console.Write(startChar++);
            }

            Console.WriteLine();

            // Задание 3
            int m = 5;
            int n2 = 9;
            Console.WriteLine("Задание 3:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            // Задание 4
            int rangeStart2 = -300;
            int rangeEnd2 = 200;
            int multiple = 7;
            int count = 0;
            Console.WriteLine("Задание 4:");
            for (int i = rangeStart2; i <= rangeEnd2; i++)
            {
                if (i % multiple == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine("\nКоличество кратных чисел: " + count);

            // Задание 5
            int startValue = 5;
            int endValue = 82;
            int difference = 35;
            Console.WriteLine("Задание 5:");
            while (Math.Abs(startValue - endValue) >= difference)
            {
                Console.WriteLine("i: " + startValue + ", j: " + endValue);
                startValue++;
                endValue--;
            }
        }
    }
}