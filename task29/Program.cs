// Задача 29: Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.

int [] array = FillArray(8);
PrintArray(array);

int[] FillArray(int size)
{
    int [] res = new int [size];
    for (int i=0; i<size;i++)
    {
        res[i] = new Random().Next(100);
    }
    return res;
}

void PrintArray(int[] array)
{int count =array.Length;
    for (int i = 0; i<count; i++)
     {
     Console.Write($" {String.Join(",", array[i])}");
     }
Console.WriteLine();
}
