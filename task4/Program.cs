Console.Clear();
Console.WriteLine("Напиши три числа через ENTER: ");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());
int m=0;
if (a>b)
{
     m = a;
}
if (b>m)
{
     m = b;
}
if (c>m)
{
     m = c;
}
Console.WriteLine($"{m} является максимальным из трех введенных");