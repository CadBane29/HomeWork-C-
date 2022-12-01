// Задача 43: Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double SearchDirectByX(double b1, double k1, double b2, double k2)
{               //4 - 2 / 9-5 
    double x = (b2 - b1) / (k1 - k2);
    return Math.Round(x, 1);
}

double SearchDirectByY(double b1, double k1, double b2, double k2)
{
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return Math.Round(y, 1);
}

Console.Write("Введите координаты первой точки: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты третьей точки: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты четвёртой точки: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double searchX = SearchDirectByX(b1, k1, b2, k2);
double searchY = SearchDirectByY(b1, k1, b2, k2);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> ({searchX}; {searchY})");