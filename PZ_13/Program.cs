namespace PZ_13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1:");

            int a1 = 6;
            int d = 2;

            Console.WriteLine("Введите номер члена прогрессии: ");
            int n = int.Parse(Console.ReadLine());

            int an = CalculateNthTerm(a1, d, n);
            Console.WriteLine($"n-ый член прогрессии: {an}");

            static int CalculateNthTerm(int a1, int d, int n)
            {
                if (n == 1)
                {
                    return a1;
                }
                else
                {
                    return CalculateNthTerm(a1, d, n - 1) + d;
                }
            }

            Console.WriteLine("Задание 2:");

            Console.WriteLine("Введите номер элемента в геометрической прогрессии:");
            int s = Convert.ToInt32(Console.ReadLine());
            int result = CalculateGeometricProgression(10, 5, n);
            Console.WriteLine($"n-ый член геометрической прогрессии: {result}");

            static int CalculateGeometricProgression(int b1, int q, int n)
            {
                if (n == 1)
                {
                    return b1;
                }
                else
                {
                    return q * CalculateGeometricProgression(b1, q, n - 1);
                }
            }

            Console.WriteLine("Задание 3:");
            Console.WriteLine("Введите первое число A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число B:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Все числа от A до B: ");
            if (A < B)
            {
                PrintNumbersAscending(A, B);
            }
            else
            {
                PrintNumbersDescending(A, B);
            }



            static void PrintNumbersAscending(int A, int B)
            {
                if (A <= B)
                {
                    Console.WriteLine(A);
                    PrintNumbersAscending(A + 1, B);
                }
            }

            static void PrintNumbersDescending(int A, int B)
            {
                if (A >= B)
                {
                    Console.WriteLine(A);
                    PrintNumbersDescending(A - 1, B);
                }
            }


            Console.WriteLine("Задание 4:");

            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите степень i:");
            int i = int.Parse(Console.ReadLine());

            int res = Power(a, i);
            Console.WriteLine($"{a} в степени {i} равно {res}");

            static int Power(int a, int i)
            {
                if (i == 0)
                {
                    return 1;
                }
                return a * Power(a, i - 1);
            }
        }
    }
}
