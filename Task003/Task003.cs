// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }
}

// Посмотрите пожалуста домашнее задание от 21.12.2023 г.
// Я разобрался в своих ошибках и всё исправил.
// Спасибо большое)