Console.Clear();
Console.WriteLine("Ввести целое число: ");
int a=int.Parse(Console.ReadLine());
int b=a%2;
if (b==0)
{
    Console.Write($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} не четное");
}