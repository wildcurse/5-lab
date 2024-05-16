using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите путь к файлу:");
        string filePath = Console.ReadLine();

        string fileName = GetFileNameFromPath(filePath);

        Console.WriteLine($"\nИмя файла: {fileName}");
    }

    static string GetFileNameFromPath(string path)
    {
        // Разделяем путь по символу разделителя директорий
        string[] pathParts = path.Split(System.IO.Path.DirectorySeparatorChar);

        // Имя файла будет последним элементом массива
        return pathParts[pathParts.Length - 1];
    }
}