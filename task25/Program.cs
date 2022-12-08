// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

int Sq1(int a, int b)
{ 
    int c =1;
    for(int i=1;i<=b;i++)
    {
        c = c*a;
        
    } 
    return c;
}


Console.WriteLine("Число, которое возводим в степень: ");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("Степень, в которую возводим число ");
int b= int.Parse(Console.ReadLine());
Console.WriteLine($"Число {a} в {b} степени равно {Sq1(a, b)}");
