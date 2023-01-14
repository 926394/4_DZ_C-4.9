// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные(четные) числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 6 -> "6, 4, 2"        // N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 6, 4, 2"     // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Здравствуйте! Ниже, введите числа от N до M");
Console.WriteLine();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

int RecursEvenNum(int first, int num)
{
    if (first == num) return first;

    RecursEvenNum(first, num - 1);

    int rec = 0;
    if (num % 2 == 0)
    {
        rec = num;
        Console.Write($"{rec} ");
    }

    return rec;
}
Console.WriteLine(RecursEvenNum(N, M));