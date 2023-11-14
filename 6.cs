using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int D = 5; // Замените это на ваше число
        int K = 3; // Замените это на ваше число
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; // Замените это на вашу последовательность

        var result = sequence
            .TakeWhile(n => n <= D) // Выбираем элементы до первого элемента, большего D
            .Concat(sequence.Skip(K - 1)) // Объединяем с элементами, начиная с K
            .Distinct() // Удаляем дубликаты
            .OrderByDescending(n => n); // Сортируем по убыванию

        Console.WriteLine("Результат: ");
        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}