//Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
Console.Clear();
int[] numbers = FillArray(5);
Console.Write($" {String.Join(",", numbers)}");
Console.WriteLine();
PrintArray(numbers);

int[] FillArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}


void PrintArray(int[] array)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i] % 2 == 0) count = count + 1;
    }
    Console.WriteLine($"Колличество четных чисел = {count}");
}
