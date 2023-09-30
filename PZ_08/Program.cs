using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // создание ступенчатого массива
        int[][] array = new int[9][];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int length = rand.Next(10, 20);
            array[i] = new int[length];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = rand.Next();
            }
        }

        // вывод сгенерированного массива
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(string.Join(" ", array[i]));
        }

        // создание нового одномерного массива и запись последних элементов каждой строки
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i].Last();
        }

        // вывод нового массива
        Console.WriteLine("Массив с последними элементами каждой строки:");
        Console.WriteLine(string.Join(" ", newArray));

        // поиск максимального элемента в каждой строке
        int[] maxArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            maxArray[i] = array[i].Max();
        }

        // вывод массива с максимальными элементами
        Console.WriteLine("Массив с максимальными элементами каждой строки:");
        Console.WriteLine(string.Join(" ", maxArray));

        // замена первого элемента и максимального в каждой строке
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = Array.IndexOf(array[i], maxArray[i]);
            int temp = array[i][0];
            array[i][0] = array[i][maxIndex];
            array[i][maxIndex] = temp;
        }

        // вывод обновленного массива
        Console.WriteLine("Обновленный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(string.Join(" ", array[i]));
        }

        // реверс каждой строки массива
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i].Reverse().ToArray();
        }

        // вывод массива после реверса
        Console.WriteLine("Массив после реверса:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(string.Join(" ", array[i]));
        }

        // подсчет среднего значения в каждой строке
        double[] averageArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            averageArray[i] = array[i].Average();
        }

        // вывод среднего значения в каждой строке
        Console.WriteLine("Среднее значение в каждой строке:");
        Console.WriteLine(string.Join(" ", averageArray));

        // подсчет общего количества символов в каждой строке
        int[] characterCountArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            characterCountArray[i] = array[i].Sum(x => x.ToString().Length);
        }

        // вывод общего количества символов в каждой строке
        Console.WriteLine("Общее количество символов в каждой строке:");
        Console.WriteLine(string.Join(" ", characterCountArray));

        // поиск наиболее встречающихся символов в каждой строке
        char[] mostFrequentCharacterArray = new char[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            mostFrequentCharacterArray[i] = array[i]
                .SelectMany(x => x.ToString())
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .First()
                .Key;
        }

        // вывод наиболее встречающихся символов в каждой строке
        Console.WriteLine("Наиболее встречающиеся символы в каждой строке:");
        Console.WriteLine(string.Join(" ", mostFrequentCharacterArray));
    }
}