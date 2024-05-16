using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите пять чисел:");
        string input = Console.ReadLine();

        // Преобразуем введенные данные в массив чисел
        int[] numbers = ParseNumbers(input);

        if (numbers.Length != 5)
        {
            Console.WriteLine("Ошибка: Пожалуйста, введите ровно пять чисел.");
            return;
        }

        // Находим максимальное и минимальное число
        int maxNumber = numbers.Max();
        int minNumber = numbers.Min();

        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
    }

    static int[] ParseNumbers(string input)
    {
        // Разделяем строку на части и преобразуем в массив чисел
        string[] parts = input.Split(' ');
        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        return numbers;
    }
}
