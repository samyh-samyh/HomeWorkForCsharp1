// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
using System;
using static System.Console;


Clear();
WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(ReadLine());
WriteLine();
WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(ReadLine());
WriteLine();
WriteLine("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(ReadLine());
WriteLine();
WriteLine("Введите диапазон случайных чисел: от 1 до: ");
int range = int.Parse(ReadLine());
WriteLine();

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
WriteLine($"Первая матрица:");
PrintArray(firstMartrix);
WriteLine();

int[,] secomdMartrix = new int[n, p];
GetArray(secomdMartrix);
WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);
WriteLine();

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine($"Произведением матриц будет: ");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        WriteLine();
    }
}