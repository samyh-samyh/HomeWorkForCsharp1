// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
// элементов массива.

Console.Clear();
double[] baseArray = GetArray(5,-5,5);
PrintMaxMinDiff(baseArray);

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}

void PrintMaxMinDiff(double [] array)
{
    Console.Write(String.Join(";  ", array));
    double min=array[0];
    double max=array [0];
    double diff=0;
    for (int i=1; i<array.Length; i++)
    {
        if (min>array[i]){min=array[i];}
        if (max<array[i]){max=array[i];}
        diff=max-min;
    }
    Console.WriteLine($"min={min}, max={max}, difference={diff}");
}
