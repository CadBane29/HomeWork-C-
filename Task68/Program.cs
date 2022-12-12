// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int firstNumberM = -1;
int secondNumberN = -1;

while(firstNumberM < 0)
{
    Console.Write("Введите натуральное число M: ");
    firstNumberM = Convert.ToInt32(Console.ReadLine());
    if (firstNumberM < 0) Console.WriteLine("Число Аккермана должно быть натуральным!");
}
while(secondNumberN < 0)
{
    Console.Write("Введите натуральное число N: ");
    secondNumberN = Convert.ToInt32(Console.ReadLine());
    if (secondNumberN < 0) Console.WriteLine("Число Аккермана должно быть натуральным!");
}

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int ackermann = AckermannFunction(firstNumberM, secondNumberN);
Console.WriteLine($"m = {firstNumberM}, n = {secondNumberN} -> A(m,n) = {ackermann}");