// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();
WriteLine("Введите первое число, которое будет меньше второго: ");
int m = int.Parse(ReadLine());
WriteLine("Введите второе число, которое будет больше первого: ");
int n = int.Parse(ReadLine());
WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int CountNaturalSum(int m, int n)
{
    if (m == n)   return n;
    else return n + CountNaturalSum(m, n - 1);
}