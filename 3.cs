using System;

class Program
{
    static void Main()
    {
        int L = 5; // Замените это на вашу длину
        string[] sequence = { "12345", "abcde", "67890", "fghij", "klmno", "pqrst", "uvwxy", "z1234" }; // Замените это на вашу последовательность

        string lastString = "Not found";

        foreach (string str in sequence)
        {
            if (str.Length == L && char.IsDigit(str[0]))
            {
                lastString = str;
            }
        }

        Console.WriteLine("Последняя строка, начинающаяся с цифры и имеющая длину " + L + ": " + lastString);
    }
}