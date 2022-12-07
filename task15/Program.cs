//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.



Console.Clear();
Console.WriteLine("Введи номер дня недели(от 1 до 7): ");
Console.Clear();
int day = int.Parse(Console.ReadLine());
for (;day<6 && day>=1;) {Console.WriteLine($"{day} является рабочим"); break;}
for (;day>=6 && day<=7;) {Console.WriteLine($"{day} является выходным");break;}
for (;day<=0 || day>=8;) {Console.WriteLine($"значение {day} некорректно"); break;}



    //if (day>=1) Console.WriteLine($"{day} является рабочим");
    //if (day>=6) Console.WriteLine($"{day} является выходным");
    //else Console.WriteLine($"значение {day} некорректно");
    //break;