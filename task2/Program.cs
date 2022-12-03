Console.Clear();
Console.WriteLine("Введи два числа: ");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"max= {a}, min= {b}");
}
else
{
    Console.WriteLine($"max= {b}, min= {a}");
}
if (a==b)
{
    Console.WriteLine("Числа одинаковы");
}