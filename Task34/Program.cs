// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int size = -1;
while (size <= 0)
{
    Console.Write("Пользователь, введите размер массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    if (size <= 0) Console.WriteLine("Пользователь, введите корректный размер массива!");
}

int[] createArrayInt = CreateArrayRndInt(size, 100, 999);
PrintArray(createArrayInt);

int EvenNumberArray(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

int evenNumber = EvenNumberArray(createArrayInt);
Console.WriteLine($"В вашем массиве {evenNumber} чётных числа!");