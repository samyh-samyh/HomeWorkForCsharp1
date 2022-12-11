//Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

Console.Clear();
int[] numbers = FillArray(5);
Console.Write($" {String.Join(", ", numbers)}");
Console.WriteLine();
PrintArray(numbers);

int[] FillArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 11);
    }
    return res;
}


void PrintArray(int[] array)
{
    int length = array.Length;
    int count = 0;
    for (int i = 1; i < length; i=i+2)
    {
        if (i%2!=0) count = count + array[i];
    }
    Console.WriteLine($"Сумма элементов нечетных позиций массива = {count}");
}
