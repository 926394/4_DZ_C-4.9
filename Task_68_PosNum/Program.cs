// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.Write("Здравствуйте! Ниже, введите числа");
Console.WriteLine();
Console.Write("Первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Второе число: ");
int N = int.Parse(Console.ReadLine()!);

int AnkermanFun(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }

    if ((a > 0) && (b == 0))
    {
        return AnkermanFun(a - 1, 1);
    }

    if ((a > 0) && (b > 0))
    {
        return AnkermanFun(a - 1, AnkermanFun(a, b - 1));
    }

    return b;
}

Console.WriteLine(AnkermanFun(M, N));
