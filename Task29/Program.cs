// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = rnd.Next(29, 2023);
    }
}

void PrintArray(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}

RandomArray(arr);
PrintArray(arr);