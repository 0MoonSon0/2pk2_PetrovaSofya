namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пользователь воодит значения
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.PI / 2;
            //

            //Первое действие
            double res1 = Math.Log(5) / Math.Sin(c);
            //Второе действие
            double v = Math.Sqrt(-2.5 - a * a);

            double res2_1 = v;
            double res2 = Math.Abs(res2_1);
            //Третье действие
            double res3 = (Math.Pow(10, 3) * a - b) / Math.Cos(b);
            //Четвертое действие
            double v1 = Math.Abs((double)Math.Pow(-5 - a * a, 1.0 / 3.0));
            double res4 = v1;
            //Пятое действие
            double res5 = -2.5 * c;
            //Вывод
            double resultat = (res1 - res2 - res3 + res4 - res5);
            Console.WriteLine(resultat);
        }
    }
}