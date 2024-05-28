namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void SortDec3(ref double A, ref double B, ref double C)
            {
                if (A < B)
                {
                    double temp = A;
                    A = B;
                    B = temp;
                }

                if (B < C)
                {
                    double temp = B;
                    B = C;
                    C = temp;
                }

                if (A < B)
                {
                    double temp = A;
                    A = B;
                    B = temp;
                }
            }

            double A1 = 5.2, B1 = 3.7, C1 = 1.9;
            double A2 = 4.8, B2 = 6.1, C2 = 2.5;

            SortDec3(ref A1, ref B1, ref C1);
            SortDec3(ref A2, ref B2, ref C2);

            Console.WriteLine($"Первый набор чисел: {A1}, {B1}, {C1}");
            Console.WriteLine($"Второй набор чисел: {A2}, {B2}, {C2}");
        }
    }
}
