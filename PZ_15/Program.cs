namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Запрос пути к каталогу у пользователя
                Console.Write("Введите путь к каталогу: ");
                string directoryPath = Console.ReadLine();

                // Проверка существования каталога
                if (!Directory.Exists(directoryPath))
                {
                    Console.WriteLine("Каталог не существует");
                    return;
                }

                // Перебор всех файлов в каталоге
                foreach (string filePath in Directory.GetFiles(directoryPath))
                {
                    try
                    {
                        // Получение информации о файле
                        FileInfo fileInfo = new FileInfo(filePath);

                        // Проверка размера файла
                        if (fileInfo.Length > 10 * 1024 * 1024) // Размер более 10 Мб
                        {
                            // Вывод информации о файле в консоль
                            Console.WriteLine($"Найден файл: {fileInfo.Name}");
                            Console.WriteLine($"Путь: {fileInfo.FullName}");
                            Console.WriteLine($"Размер: {fileInfo.Length} байт");
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка обработки файла: {filePath}");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
