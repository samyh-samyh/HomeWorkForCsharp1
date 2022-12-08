// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int num=int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {sum(num)} ");

int sum(int number)
{
    int cou=0;
    int answer=0;
    int size=a(num);
    for(int i=0;i<size;i++)
    {
        cou=number-number%10;
        answer=answer+(number-cou);
        number=number/10;
    }
    return answer;
}

int a(int number)
{
    int count = 0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}
