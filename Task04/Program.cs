// Задача 4: Напишите программу, которая 
//1. принимает на вход три числа и 
//2. выдаёт максимальное из этих чисел. //задача через переменную max

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
Console.WriteLine("Пользователь, введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пользователь, введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пользователь, введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxValue = number1;
if (number1 > maxValue) maxValue = number1;
if (number2 > maxValue) maxValue = number2;
if (number3 > maxValue) maxValue = number3;
else if (number1 <= 0) maxValue = number1;
else if (number2 <= 0) maxValue = number2;
else if (number3 <= 0) maxValue = number3;
Console.Write($"Максимальное значение из трех чисел {maxValue}.");