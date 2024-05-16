using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        string longestWord = FindLongestWord(sentence);

        Console.WriteLine($"\nСамое длинное слово: {longestWord}");
    }

    static string FindLongestWord(string sentence)
    {
        // Разделяем предложение на слова
        string[] words = sentence.Split(' ');

        string longestWord = "";
        int maxLength = 0;

        // Ищем самое длинное слово
        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
                longestWord = word;
            }
        }

        return longestWord;
    }
}
