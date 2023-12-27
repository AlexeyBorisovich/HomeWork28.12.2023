// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.



using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {m} до {n}:");

        PrintNaturalNumbers(m, n);
    }

    static void PrintNaturalNumbers(int current, int end)
    {
        if (current < end + 1)
        {
            Console.WriteLine(current);
            PrintNaturalNumbers(current + 1, end);
        }
    }
}