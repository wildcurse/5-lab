using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество ступеней:");
        int levels;

        while (!int.TryParse(Console.ReadLine(), out levels) || levels <= 0)
        {
            Console.WriteLine("Пожалуйста, введите корректное положительное целое число.");
        }

        PrintNumberPyramid(levels);
    }

    static void PrintNumberPyramid(int levels)
    {
        for (int i = 1; i <= levels; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
