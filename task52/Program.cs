// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк:");
int rows = int.Parse(ReadLine());

WriteLine("Введите колличество столбцов:");
int columns = int.Parse(ReadLine());

WriteLine();
WriteLine();

int[,] massiv = GetArray(rows, columns, 1, 9);
PrintArray(massiv);
double[] average = FindAvrgColums(massiv);
WriteLine($"Среднее арифметическое каждого столбца = {String.Join(" | ", average)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] ex = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ex[i, j] = new Random().Next(min, max + 1);
        }
    }
    return ex;
}

void PrintArray(int[,] Ex)
{
    for (int i = 0; i < Ex.GetLength(0); i++)
    {
        for (int j = 0; j < Ex.GetLength(1); j++)
        {
            Write($"{Ex[i, j]}   ");
        }
        WriteLine();
    }
}

double[] FindAvrgColums(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result[i] = Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}
