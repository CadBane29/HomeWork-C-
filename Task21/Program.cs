// Задача 21
// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Пользователь, введите координату первой точки: ");
double dotA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Пользователь, введите координату второй точки: ");
double dotB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Пользователь, введите координату третьей точки: ");
double dotС = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Пользователь, введите координату четвертой точки: ");
double dotD = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Пользователь, введите координату пятой точки: ");
double dotE = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Пользователь, введите координату шестой точки: ");
double dotF = Convert.ToDouble(Console.ReadLine());

double Distance(double pointA, double pointB, double pointC,
                double pointD, double pointE, double pointF)
{
    double pointAD = (pointA - pointD) * (pointA - pointD);
    double pointBE = (pointB - pointE) * (pointB - pointE);
    double pointCF = (pointC - pointF) * (pointC - pointF);
    double distanceSpace = Math.Sqrt(pointAD + pointBE + pointCF);
    return distanceSpace;
}
double distance = Distance(dotA, dotB, dotС, dotD, dotE, dotF);
double result = Math.Round(distance, 4, MidpointRounding.ToEven);
Console.WriteLine($"Расстояние между указанными вами точками в 3D пространстве: {result}.");
