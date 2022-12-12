// Задача 64: Задайте значение N. 
// 1. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// 2. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumberRec(int num)
{
    if (num != 0)
    {
        Console.Write($"{num} ");
        NaturalNumberRec(num - 1);
    }
}

int numbN = -1;
while (numbN <= 0)
{
    Console.Write("Введите натуральное число: ");
    numbN = Convert.ToInt32(Console.ReadLine());
    if (numbN <= 0) Console.WriteLine("Введите другое число!");
}

Console.Write($"N = {numbN} -> ");
NaturalNumberRec(numbN);