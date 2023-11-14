using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int K = 2; // Замените это на ваше число
        string[] sequence = { "ABC", "123", "DEF", "456", "GHI", "789", "JKL", "0MN", "OPQ", "RST", "UVW", "XYZ" }; // Замените это на вашу последовательность

        var result = sequence
            .Take(3 * K) // Выбираем первые 3K элементов
            .Intersect(sequence.SkipWhile(s => !char.IsDigit(s.Last())).Skip(1)) // Находим пересечение с элементами, оканчивающимися цифрой
            .OrderBy(s => s.Length) // Сортируем по возрастанию длин строк
            .ThenBy(s => s); // Сортируем строки одинаковой длины в лексикографическом порядке

        Console.WriteLine("Результат: ");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}