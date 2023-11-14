using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int D = 5; // Замените это на ваше число
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; // Замените это на вашу последовательность

        var extractedNumbers = sequence
            .SkipWhile(n => n <= D) // Пропускаем все числа, меньшие или равные D
            .Where(n => n > 0 && n % 2 != 0) // Выбираем только нечетные положительные числа
            .Reverse(); // Меняем порядок чисел на обратный

        Console.WriteLine("Извлеченные числа: ");
        foreach (int number in extractedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}