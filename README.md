Отчёт о проделанной работе с использованием PLINQ

Цель

Научиться использовать PLINQ для параллельной обработки данных в C# и оптимизировать производительность LINQ-запросов.

Задачи

Применить PLINQ для параллельной обработки данных в решении 6 задач.

Составить отчёт о ходе и результатах проделанной работы.

Задача 1: Фильтрация чисел

Описание

Фильтруем числа от 1 до 1 000 000, оставляя только те, которые делятся на 3 и 5.

Код

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 1: Фильтрация чисел");
        var numbers = Enumerable.Range(1, 1_000_000);

        var filteredNumbers = numbers.AsParallel().Where(n => n % 3 == 0 && n % 5 == 0);

        Console.WriteLine($"Найдено {filteredNumbers.Count()} чисел, которые делятся на 3 и 5.");
    }
}




Результат выполнения

![изображение](https://github.com/user-attachments/assets/f539f040-207a-496c-a282-d7c726eb46bc)




Задача 2: Параллельное вычисление суммы квадратов

Описание

Считаем сумму квадратов всех чисел от 1 до 1 000 000 с использованием PLINQ.

Код

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 2: Параллельное вычисление суммы квадратов");
        var numbers = Enumerable.Range(1, 1_000_000);

        var sumOfSquares = numbers.AsParallel().Select(n => n * n).Sum();

        Console.WriteLine($"Сумма квадратов чисел: {sumOfSquares}");
    }
}


Результат выполнения

![изображение](https://github.com/user-attachments/assets/790d04bb-5874-4010-84af-d3103283656e)




Задача 3: Обработка строк

Описание

Преобразуем строки в верхний регистр и фильтруем строки по длине (больше 7 символов).

Код

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 3: Обработка строк");
        var strings = Enumerable.Range(1, 1_000_000).Select(n => $"String {n}");

        var processedStrings = strings.AsParallel()
                                       .Where(s => s.Length > 7)
                                       .Select(s => s.ToUpper())
                                       .ToList();

        Console.WriteLine($"Обработано {processedStrings.Count} строк.");
    }
}


Результат выполнения

![изображение](https://github.com/user-attachments/assets/9ae34245-c29d-4fd1-b507-446d2d61c8e2)




Задача 4: Поиск максимального значения

Описание

Находим максимальное число от 1 до 1 000 000, которое делится на 7.

Код

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 4: Поиск максимального значения");
        var numbers = Enumerable.Range(1, 1_000_000);

        var maxDivisibleBy7 = numbers.AsParallel().Where(n => n % 7 == 0).Max();

        Console.WriteLine($"Максимальное число, делящееся на 7: {maxDivisibleBy7}");
    }
}


Результат выполнения

![изображение](https://github.com/user-attachments/assets/9b3e9f55-517a-4d3a-8e99-3c00b9dcd113)




Задача 5: Группировка данных

Описание

Группируем числа от 1 до 1 000 000 по остаткам от деления на 10.

Код

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 5: Группировка данных");
        var numbers = Enumerable.Range(1, 1_000_000);

        var grouped = numbers.AsParallel()
                             .GroupBy(n => n % 10)
                             .OrderBy(g => g.Key);

        foreach (var group in grouped)
        {
            Console.WriteLine($"Остаток {group.Key}: {group.Count()} чисел.");
        }
    }
}


Результат выполнения
![изображение](https://github.com/user-attachments/assets/61fb7479-1fe6-4f46-8f75-e7b2908b249d)




Задача 6: Создание объектов

Описание

Создаём сложные объекты из чисел от 1 до 1 000 000, рассчитываем их свойства и сохраняем в список.

Код

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


Результат выполнения

![изображение](https://github.com/user-attachments/assets/2c22709b-7fc4-45a4-936e-16a532cd92c5)




Вывод

В ходе выполнения задач мы:

Освоили базовые приёмы работы с PLINQ для обработки больших объёмов данных.

Узнали, как оптимизировать LINQ-запросы для повышения производительности.

Реализовали шесть задач, демонстрирующих возможности параллельных вычислений в C#.

Здесь можно добавить личные впечатления, выводы или заметки.

