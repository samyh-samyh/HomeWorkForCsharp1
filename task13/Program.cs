//Задача 10: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.



Console.Clear();
Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine());
if (number>100)
{
    int second=number%10;
    Console.WriteLine($"{number} --> третья цифра {second}");
}
else
{
     Console.WriteLine($"{number} --> третьей цифры нет");
}