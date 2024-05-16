using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения для первого массива через пробел:");
        string firstInput = Console.ReadLine();
        int[] firstArray = ParseArray(firstInput);

        Console.WriteLine("Введите значения для второго массива через пробел:");
        string secondInput = Console.ReadLine();
        int[] secondArray = ParseArray(secondInput);

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Ошибка: Длины массивов не совпадают.");
            return;
        }

        int[] resultArray = MultiplyArrays(firstArray, secondArray);

        Console.WriteLine("Результат: " + string.Join(" ", resultArray));
    }

    static int[] ParseArray(string input)
    {
        string[] parts = input.Split(' ');
        int[] array = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            array[i] = int.Parse(parts[i]);
        }
        return array;
    }

    static int[] MultiplyArrays(int[] firstArray, int[] secondArray)
    {
        int[] result = new int[firstArray.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            result[i] = firstArray[i] * secondArray[i];
        }
        return result;
    }
}
