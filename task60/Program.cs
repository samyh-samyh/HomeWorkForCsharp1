﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System;
using static System.Console;

Clear();
WriteLine($"Введите x: ");
int x = int.Parse(ReadLine()); 
WriteLine($"Введите y: ");
int y = int.Parse(ReadLine()); 
WriteLine($"Введите z: ");
int z = int.Parse(ReadLine()); 
WriteLine();

int[,,] array3D = new int[x, y, z];
GetArray(array3D);
PrintArray(array3D);


void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Write($"x({i})y({j})");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Write( $"z({k})={array3D[i,j,k]};  ");
      }
      WriteLine();
    }
    WriteLine();
  }
}

void GetArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 101);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 101);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}