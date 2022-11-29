// Задача 36: Задайте одномерный массив,
// 1. заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] createArrayInt = CreateArrayRndInt(size, -100, 100);
PrintArray(createArrayInt);

int SumElementOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1) sum += arr[i];
    }
    return sum;
}

int sumOddElement = SumElementOddPosition(createArrayInt);
Console.WriteLine(sumOddElement);