namespace PZ_14
{
    class Program
    {
        static void Main()
        {
            // Создаем текстовый файл
            string filePath = "inFile.txt";

            // Создаем объект StreamWriter для записи в файл
            using (StreamWriter sw = File.CreateText(filePath))
            {
                Console.WriteLine("Введите произвольные данные. Для завершения ввода введите пустую строку:");

                string inputData;
                do
                {
                    // Читаем данные из консоли
                    inputData = Console.ReadLine();

                    // Записываем данные в файл
                    sw.WriteLine(inputData);
                } while (!string.IsNullOrEmpty(inputData)); // Пока введенная строка не пустая
            }

            // Создаем объект FileInfo для чтения файла
            FileInfo fileInfo = new FileInfo(filePath);

            // Проверяем существование файла
            if (fileInfo.Exists)
            {
                // Читаем содержимое файла
                string fileContent = File.ReadAllText(filePath);

                // Анализируем текст на наличие чисел
                int countNumbers = CountNumbers(fileContent);

                // Выводим содержимое файла и количество чисел на консоль
                Console.WriteLine($"Содержимое файла: {fileContent}");
                Console.WriteLine($"Количество чисел в тексте: {countNumbers}");
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }

            Console.ReadLine();
        }

        // Метод для подсчета чисел в тексте
        static int CountNumbers(string text)
        {
            int count = 0;
            char prevChar = '\0';

            foreach (char c in text)
            {
                if (char.IsDigit(c) && !char.IsDigit(prevChar))
                {
                    count++;
                }
                prevChar = c;
            }

            return count;
        }
    }
}
