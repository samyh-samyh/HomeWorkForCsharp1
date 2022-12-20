// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using static System.Console;

Clear();
WriteLine("Введите два положительных числа: M и N.");
int m = int.Parse(ReadLine());
int n = int.Parse(ReadLine());
WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}