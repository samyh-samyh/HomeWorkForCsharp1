//Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введи трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int second=number/10%10;
Console.WriteLine($"{number} --> {second}");