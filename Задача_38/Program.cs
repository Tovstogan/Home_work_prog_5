/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/



int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0,10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void Findminandmax(int[] arr)
{
    int max = 0;
    int min = arr[1];
    for (int i = 0; i< arr.Length; i++)
    {
        if(arr[i]<min)
        {
            min = arr[i];
        }
    }
    for (int i = 0; i< arr.Length; i++)
    {
        if(arr[i]>max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine($"Минимальный элемент: {min}");
    Console.WriteLine($"Максимальный элемент: {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");
}
int[] array = GetArray(8);
Findminandmax(array);
PrintArray(array);