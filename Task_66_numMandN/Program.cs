// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Здравствуйте! Ниже, введите диапазон слагаемых");
Console.WriteLine();
Console.Write("Введите первое слагаемое: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе слагаемое: ");
int N = int.Parse(Console.ReadLine()!);

int SumNumMandN(int first, int and)
{
    if (first == and) return first;

    return (first + SumNumMandN(first + 1, and));
}

Console.WriteLine(SumNumMandN(M, N));