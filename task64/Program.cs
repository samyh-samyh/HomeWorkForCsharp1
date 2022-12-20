// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1
using System;
using static System.Console;

Clear();
WriteLine("Введите натуральное число: ");
int n = int.Parse(ReadLine());
int m = 1;
if (n < 1) WriteLine("Требовалось ввести натуральное число");
WriteLine(Numbers(n, m));

int Numbers(int n, int m)
{
    if (n == m) return n;
    if (n!=m && n>m) Console.Write($"{Numbers(n, m + 1)}, ");
    return m;
}