using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public int SchoolNumber { get; set; }
    public int GraduationYear { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { SchoolNumber = 1, GraduationYear = 2020, LastName = "Smith" },
            new Student { SchoolNumber = 2, GraduationYear = 2020, LastName = "Johnson" },
            new Student { SchoolNumber = 1, GraduationYear = 2021, LastName = "Williams" },
            new Student { SchoolNumber = 3, GraduationYear = 2021, LastName = "Brown" },
            // Добавьте свои данные
        };

        var result = students
            .GroupBy(s => s.GraduationYear)
            .Select(g => new { Year = g.Key, Count = g.Count() })
            .OrderBy(r => r.Count)
            .ThenBy(r => r.Year);

        var minCount = result.First().Count;
        var maxCount = result.Last().Count;

        Console.WriteLine($"Минимальное число студентов: {minCount}");
        foreach (var r in result.Where(r => r.Count == minCount))
        {
            Console.WriteLine($"{r.Count} студентов в {r.Year} году");
        }

        Console.WriteLine($"Максимальное число студентов: {maxCount}");
        foreach (var r in result.Where(r => r.Count == maxCount))
        {
            Console.WriteLine($"{r.Count} студентов в {r.Year} году");
        }
    }
}