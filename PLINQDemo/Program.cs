using System;
using System.Linq;

class MyObject
{
    public int Value { get; set; }
    public int Square { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 6: Создание объектов");
        var numbers = Enumerable.Range(1, 1_000_000);

        var objects = numbers.AsParallel()
                             .Select(n => new MyObject
                             {
                                 Value = n,
                                 Square = n * n
                             })
                             .ToList();

        Console.WriteLine($"Создано {objects.Count} объектов.");
    }
}
