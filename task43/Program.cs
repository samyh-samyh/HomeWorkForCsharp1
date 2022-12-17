// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//  задаются пользователем.
Console.Clear();
Console.WriteLine(" Для уравнений: y = k1 * x + b1; y = k2 * x + b2;");
Console.WriteLine("введите значение b1");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Double.Parse(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Double.Parse(Console.ReadLine());
GetPointOfCross(b1, b2, k1, k2);

void GetPointOfCross(double b1, double b2, double k1, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точкой пересечения двух прямых будет: ({x};{y})");
}