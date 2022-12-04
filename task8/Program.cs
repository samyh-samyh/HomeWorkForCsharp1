Console.Clear();
Console.WriteLine("Ввести целое положительное число: ");
int number=int.Parse(Console.ReadLine());
int a=0;
while (a<number-1)
{
    a=a+2;
    Console.WriteLine(a);
}