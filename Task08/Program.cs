// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N. //while

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите четное число N.");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (N > 2)
{
    if (N % 2 == 0)
    {
        Console.Write($"{N}, ");
        N = N - 2;
        count++;
    }
    else
    {
        Console.WriteLine("Вы ввели неккоректное число: ");
        break;
    }
}
Console.Write(N);