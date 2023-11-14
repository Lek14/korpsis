using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int K = 5; // Замените это на ваше число
        string[] sequence = { "Hello", "world", "I", "am", "a", "C#", "programmer" }; // Замените это на вашу последовательность

        var extractedStrings = sequence
            .Take(K) // Выбираем элементы до K
            .Where(s => s.Length % 2 != 0 && char.IsUpper(s[0])) // Фильтруем строки, начинающиеся с заглавной буквы и имеющие нечетную длину
            .Reverse(); // Меняем порядок строк на обратный

        Console.WriteLine("Извлеченные строки: ");
        foreach (string str in extractedStrings)
        {
            Console.WriteLine(str);
        }
    }
}