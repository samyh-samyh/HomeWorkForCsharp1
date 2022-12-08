//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Введите X для первой точки А: ");
int X =int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y для первой точки А: ");
int Y =int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z для первой точки А: ");
int Z =int.Parse(Console.ReadLine());
Console.WriteLine("Введите X1 для второй точки Б: ");
int X1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1 для второй точки Б: ");
int Y1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1 для второй точки Б: ");
int Z1 =int.Parse(Console.ReadLine());
double S= Math.Sqrt((Math.Pow(X-X1,2))+(Math.Pow(Y-Y1,2))+(Math.Pow(Z-Z1,2)));
Console.WriteLine($"Расстояние между точками А({X},{Y},{Z}) и Б({X1},{Y1},{Z1})  равно ={S:f2} ");