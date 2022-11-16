// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и на 
// 2. выходе показывает вторую цифру этого числа. 
// --Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Пользователь, введите трёхзначное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int OneOfThem (int fullNumber)
{
    int result = fullNumber % 100 / 10;
    return result;   
}
int oneOfThem = OneOfThem(secondNumber);

Console.WriteLine(secondNumber > 0 ? $"Вторая цифра вашего числа: {oneOfThem}" : "Пользователь, введите другое число.");