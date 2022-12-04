//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.



Console.Clear();
Console.WriteLine("Введи номер дня недели(от 1 до 7): ");
int day=int.Parse(Console.ReadLine());
if (day>5) Console.WriteLine("да");
else Console.WriteLine("нет");