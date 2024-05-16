using System;

class Program
{
    static void Main()
    {
        // запрашиваем и получаем первое число
        Console.Write("Enter the First number:\n>");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        // запрашиваем и получаем второе число
        Console.Write("Enter the Second number:\n>");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        // запрашиваем и получаем третье число
        Console.Write("Enter the third number:\n>");
        double thirdNumber = Convert.ToDouble(Console.ReadLine());

        // запрашиваем и получаем четвертое число
        Console.Write("Enter the four number:\n>");
        double fourthNumber = Convert.ToDouble(Console.ReadLine());

        // вычисляем среднее значение
        double average = CalculateAverage(firstNumber, secondNumber, thirdNumber, fourthNumber);

        // вводим результат
        Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is: {average}");
    }

    static double CalculateAverage(double num1, double num2, double num3, double num4)
    {
        double sum = num1 + num2 + num3 + num4;
        return sum / 4;
    }
}
