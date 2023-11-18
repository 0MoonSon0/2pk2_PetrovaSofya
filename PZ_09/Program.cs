using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        // Разделяем строку на слова, используя пробелы в качестве разделителя
        string[] words = input.Split(' ');

        int vowelCount = 0; // количество слов, заканчивающихся на гласную букву
        int consonantCount = 0; // количество слов, заканчивающихся на согласную букву
        int wordCount = 0; // общее количество слов
        int totalLength = 0; // общая длина всех слов

        foreach (string word in words)
        {
            char lastChar = word.ToLower().Last(); // последняя буква в слове

            if (IsVowel(lastChar))
            {
                vowelCount++;
            }
            else
            {
                consonantCount++;
            }

            wordCount++;
            totalLength += word.Length;
        }

        double averageLength = (double)totalLength / wordCount; // средняя длина слова

        Console.WriteLine("Количество слов, заканчивающихся на гласную: " + vowelCount);
        Console.WriteLine("Количество слов, заканчивающихся на согласную: " + consonantCount);
        Console.WriteLine("Средняя длина слова: " + Math.Round(averageLength, 2));
    }

    // Функция для проверки, является ли символ гласной буквой
    static bool IsVowel(char c)
    {
        return "aeiou".Contains(c);
    }
}
