// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N. //while

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число N.");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1; // If count = -n, terminal output of -n to n, example: -10, -8, -6, -4, -2, 0, 2, 4, 6, 8, 10,
while (count <= n)
{
    if (count % 2 == 0) Console.Write($"{count},");count = count + 1;
}


// Console.WriteLine("Введите число: ");
// string inputN = Console.ReadLine() ?? "";
// double numberN = Convert.ToDouble(inputN);
// int interim = 1;

// Console.Write($" {numberN} -> ");
// while (interim <= numberN)
// {
//     if (interim % 2 == 0)
//     {
//         Console.Write($" {interim}, ");
//     }
// interim++;
// }