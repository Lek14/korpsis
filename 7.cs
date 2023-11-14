using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int K = 5; // Замените это на ваше число
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; // Замените это на вашу последовательность

        var result = sequence
            .Where(n => n % 2 == 0) // Фильтруем четные числа
            .Except(sequence.Skip(K)) // Вычитаем числа с порядковыми номерами, большими K
            .Reverse(); // Меняем порядок элементов на обратный

        Console.WriteLine("Результат: ");
        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}