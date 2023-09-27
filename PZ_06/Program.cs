using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод размера массива
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        // Создание и заполнение массива
        int[] arr = new int[n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Поиск номера минимального элемента по модулю
        int minIndex = 0;
        int minValue = Math.Abs(arr[0]);
        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(arr[i]) < minValue)
            {
                minValue = Math.Abs(arr[i]);
                minIndex = i;
            }
        }

        // Вывод результата
        Console.WriteLine("Номер минимального по модулю элемента: " + minIndex);
    }
}