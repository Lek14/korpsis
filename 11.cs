using System;
using System.Linq;
using System.Collections.Generic;

public class Client
{
    public int ClientCode { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Hours { get; set; }
}

class Program
{
    static void Main()
    {
        int k = 1; // Замените на нужный код клиента

        List<Client> clients = new List<Client>
        {
            new Client { ClientCode = 1, Year = 2020, Month = 1, Hours = 2 },
            new Client { ClientCode = 1, Year = 2020, Month = 2, Hours = 3 },
            new Client { ClientCode = 1, Year = 2021, Month = 1, Hours = 1 },
            new Client { ClientCode = 2, Year = 2021, Month = 2, Hours = 4 },
            // Добавьте свои данные
        };

        var result = clients
            .Where(c => c.ClientCode == k && c.Hours > 0)
            .GroupBy(c => c.Year)
            .Select(g => g.OrderBy(c => c.Hours).ThenBy(c => c.Year).First())
            .OrderBy(c => c.Hours).ThenBy(c => c.Year);

        if (!result.Any())
        {
            Console.WriteLine("Нет данных");
        }
        else
        {
            foreach (var client in result)
            {
                Console.WriteLine($"{client.Hours} {client.Year} {client.Month}");
            }
        }
    }
}