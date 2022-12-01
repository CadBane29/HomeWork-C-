// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrayInt(int size, int min, int max)
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
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    //Console.WriteLine("]");
}

int CheckNumberGreaterZero(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            num++;
        }
    }
    return num;
}

int size = -1;
while (size <= 0)
{
    Console.Write("Введите число элементов массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    if(size <= 0) Console.WriteLine("Введите другой размер!");
}

int[] array = CreateArrayInt(size, -999, 999);
PrintArray(array);
int numberCheck = CheckNumberGreaterZero(array);
Console.WriteLine($" --> {numberCheck} числа больше нуля.");