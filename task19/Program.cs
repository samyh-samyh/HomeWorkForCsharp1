//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num=int.Parse(Console.ReadLine());
// int num= 12345;
if ((num>=10000)&&(num<=99999))
{
    int a=num/10000; int b=num/1000%10;
    int c=num%100/10; int d=num%10;
    //Console.WriteLine($"{a}, {b}, {c}, {d}");
    if((a==d)&&(b==c))
    {
        Console.WriteLine($"Число {num} являестся палиндромом");
    }
    else {Console.WriteLine($"Число {num} не являестся палиндромом"); }
}
if ((num>99999)||(num<10000)) {Console.WriteLine($"Число {num} введено некорректно, попробуйте еще раз");}
