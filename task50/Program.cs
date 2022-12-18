// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк:");
int rows = int.Parse(ReadLine());

WriteLine("Введите колличество столбцов:");
int columns = int.Parse(ReadLine());

WriteLine("Введите значение элемента:");
int element = int.Parse(ReadLine());

WriteLine();
WriteLine();

int [,] massiv = GetArray(rows, columns, 1, 9);
PrintArray(massiv);
if(FindElement(massiv, element)) WriteLine($"Элемент '{element}' найден");  else   WriteLine($"Элемент '{element}' не найден");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] ex = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ex[i, j] = new Random().Next(min, max+1);
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

bool FindElement(int[,] ex, int element)
{
    for (int i = 0; i < ex.GetLength(0); i++)
    {
        for (int j = 0; j < ex.GetLength(1); j++)
        {
            if (ex[i, j]==element) return true;
        }
    }
    return false;
}