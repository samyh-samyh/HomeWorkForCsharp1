// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк");
int rows = int.Parse(ReadLine());

WriteLine("Ввседите колличество столбцов");
int columns = int.Parse(ReadLine());

WriteLine();
WriteLine();

double[,] Massiv = GetArray(rows, columns, 1, 9);
PrintArray(Massiv);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] ex = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ex[i, j] = new Random().NextDouble() * (max - min);
        }
    }
    return ex;
}

void PrintArray(double[,] Ex)
{
    for (int i = 0; i < Ex.GetLength(0); i++)
    {
        for (int j = 0; j < Ex.GetLength(1); j++)
        {
            Write($"{Ex[i, j]:f2}   ");
        }
        WriteLine();
    }
}