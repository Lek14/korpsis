using System;

class Program
{
    static void Main()
    {
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 }; // Замените это на вашу последовательность

        int firstPositive = int.MinValue;
        int lastNegative = int.MinValue;

        foreach (int number in sequence)
        {
            if (number > 0 && firstPositive == int.MinValue)
            {
                firstPositive = number;
            }
            else if (number < 0)
            {
                lastNegative = number;
            }
        }

        Console.WriteLine("Первый положительный элемент: " + firstPositive);
        Console.WriteLine("Последний отрицательный элемент: " + lastNegative);
    }
}