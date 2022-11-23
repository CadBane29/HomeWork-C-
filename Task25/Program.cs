// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Пользователь, введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -1;

while (b <= 0)
{
    Console.WriteLine("Пользователь, введите степень в которую вы хотите возвести число: ");
    b = Convert.ToInt32(Console.ReadLine());
    if (b <= 0) Console.WriteLine("Введите другую степень!");
}

int EnterTwo(int a1, int b1)
{
    int degree = a1;
    for (int i = 1; i < b1; i++)
    {
        degree = a1 * degree;
    }
    return degree;
}

int enterTwo = EnterTwo(a, b);
Console.WriteLine($"Число {a} в степени {b} = {enterTwo}");

