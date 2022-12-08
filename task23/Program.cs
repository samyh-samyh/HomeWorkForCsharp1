//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int n =int.Parse(Console.ReadLine());
for (int i=1; i<=n; i++)
{
   Console.WriteLine(Math.Pow(i, 3));   
}
for (int j=-1; j>=n; j--)
{
   Console.WriteLine(Math.Pow(j, 3));   
}