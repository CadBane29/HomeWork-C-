// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Пользователь, введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int res = 0;
    while(num != 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return Math.Abs(res);
}

int sum = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} -> {sum}");
