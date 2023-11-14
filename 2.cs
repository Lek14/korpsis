using System;

class Program
{
    static void Main()
    {
        int D = 5; 
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10, 25, 35, -55 }; 

        int firstPositiveEndingWithD = 0;

        foreach (int number in sequence)
        {
            if (number > 0 && number % 10 == D)
            {
                firstPositiveEndingWithD = number;
                break;
            }
        }

        Console.WriteLine("Первый положительный элемент, оканчивающийся цифрой " + D + ": " + firstPositiveEndingWithD);
    }
}