// Задача 66: Задайте значения M и N. 
// 1. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 2. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberN = -1;
int numberM = -1;

while (numberN <= 0)
{
    Console.Write("Введите натуральное число N: ");
    numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN <= 0) Console.WriteLine("Введите другое число!");

}
while (numberM <= 0)
{
    Console.Write("Введите натуральное число M: ");
    numberM = Convert.ToInt32(Console.ReadLine());
    if (numberM <= 0) Console.WriteLine("Введите другое число!");
}

int SumTwoElementsRecursion(int num1, int num2)
{
    if(num1 > num2) return SumTwoElementsRecursion(num1 - 1, num2) + num1;
    else if (num2 > num1) return SumTwoElementsRecursion(num1, num2 - 1) + num2;
    return num2;
}

int sum = SumTwoElementsRecursion(numberM, numberN);
Console.Write($"M = {numberN}; N = {numberM} -> {sum}");