// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N. //while

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число N.");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
        count = count + 1;
    }
    else if (count % 1 == 0)
    {
        Console.Write(" ");
        count = count + 1;
    }
}
