//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//будет находить строку с наименьшей суммой элементов.
using System;
using static System.Console;


Clear();
WriteLine($"Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
WriteLine($"Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
WriteLine($"Введите диапозон чисел которые будут находиться в составе массива: ");
int range = int.Parse(ReadLine());

int[,] array = new int[rows, columns];
GetArray(array);
PrintArray(array);

WriteLine();


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
        Console.WriteLine();
    }
}

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


WriteLine($" '{minSumLine+1}'строка имеет наименьшую сумму элементов и равна {sumLine}");
