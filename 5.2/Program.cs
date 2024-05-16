using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два числа:");
        double num1 = GetNumber("> ");
        double num2 = GetNumber("> ");

        Console.WriteLine($"\nВы ввели числа: {num1} и {num2}");
        Console.WriteLine("Какое действие выполнить?");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Нахождение остатка");

        string action = Console.ReadLine();

        switch (action)
        {
            case "1":
                Console.WriteLine($"\nРезультат: {num1} + {num2} = {num1 + num2}");
                break;
            case "2":
                Console.WriteLine($"\nРезультат: {num1} - {num2} = {num1 - num2}");
                break;
            case "3":
                Console.WriteLine($"\nРезультат: {num1} * {num2} = {num1 * num2}");
                break;
            case "4":
                if (num2 != 0)
                {
                    Console.WriteLine($"\nРезультат: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("\nОшибка: Деление на ноль невозможно.");
                }
                break;
            case "5":
                if (num2 != 0)
                {
                    Console.WriteLine($"\nРезультат: {num1} % {num2} = {num1 % num2}");
                }
                else
                {
                    Console.WriteLine("\nОшибка: Деление на ноль невозможно.");
                }
                break;
            default:
                Console.WriteLine("\nНекорректный выбор. Пожалуйста, выберите действие от 1 до 5.");
                break;
        }
    }

    static double GetNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }
    }
}
