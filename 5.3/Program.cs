using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите шкалу вводимой температуры:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");
        string inputScale = Console.ReadLine();

        Console.WriteLine("\nВведите показатель температуры (градусы):");
        double inputTemperature = GetTemperature("> ");

        Console.WriteLine("\nВыберите тип шкалы для конвертации:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");
        string outputScale = Console.ReadLine();

        double result = ConvertTemperature(inputTemperature, inputScale, outputScale);

        string inputScaleName = GetScaleName(inputScale);
        string outputScaleName = GetScaleName(outputScale);

        Console.WriteLine($"\nВы выбрали: {inputScaleName} -> {outputScaleName}");
        Console.WriteLine($"Результат конвертации: {result}");
    }

    static double GetTemperature(string prompt)
    {
        double temperature;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out temperature))
            {
                return temperature;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }
    }

    static double ConvertTemperature(double temp, string inputScale, string outputScale)
    {
        double tempInCelsius;

        // Convert input temperature to Celsius
        switch (inputScale)
        {
            case "1": // Celsius
                tempInCelsius = temp;
                break;
            case "2": // Kelvin
                tempInCelsius = temp - 273.15;
                break;
            case "3": // Fahrenheit
                tempInCelsius = (temp - 32) * 5 / 9;
                break;
            default:
                throw new ArgumentException("Некорректная шкала ввода.");
        }

        // Convert Celsius to output scale
        switch (outputScale)
        {
            case "1": // Celsius
                return tempInCelsius;
            case "2": // Kelvin
                return tempInCelsius + 273.15;
            case "3": // Fahrenheit
                return tempInCelsius * 9 / 5 + 32;
            default:
                throw new ArgumentException("Некорректная шкала вывода.");
        }
    }

    static string GetScaleName(string scale)
    {
        switch (scale)
        {
            case "1":
                return "Цельсий";
            case "2":
                return "Кельвин";
            case "3":
                return "Фаренгейт";
            default:
                return "Неизвестная шкала";
        }
    }
}
