// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear(); 
Console.Write("Введите числа через пробел: "); 
string elements = Console.ReadLine(); 
int[] array = GetArrayFromString(elements); 
 
Console.WriteLine($"Колличество введенных положительных чисел= {CountOfPosNums(array)}"); 
 
int[] GetArrayFromString(string numbers) 
{ 
    string[] nums = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
    int[] res = new int[nums.Length]; 
 
    for (int i = 0; i < nums.Length; i++) 
    { 
        res[i] = int.Parse(nums[i]); 
    } 
    return res; 
}

int CountOfPosNums(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item>0) count++;
    }
    return count;
}