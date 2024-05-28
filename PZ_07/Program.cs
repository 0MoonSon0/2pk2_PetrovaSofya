using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив  3x3
        int[,] matrix = new int[3, 3] { { 1, 0, 2 }, { 3, 4, 5 }, { 6, 7, 0 } };

        // Находим размерность квадратной матрицы
        int size = (int)Math.Sqrt(matrix.Length);
       
        int product = 1;

        // Проходим по главной диагонали и умножаем ненулевые элементы
        for (int i = 0; i < size; i++)
        {
            if (matrix[i, i] != 0)
            {
                product *= matrix[i, i];
            }
        }

        // Выводим результат
        Console.WriteLine("Произведение ненулевых диагональных элементов: " + product);
    }
}