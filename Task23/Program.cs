// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


int numberN = -1;
while(numberN < 1)
{
    Console.Write("Пользователь, введите число от одного до N: ");
    numberN = Convert.ToInt32(Console.ReadLine());
    if(numberN < 1) Console.WriteLine("Пользователь, введите корректное число!");
}

void NumberN (int numberCube)
{
    for(int i = 1; i <= numberCube; i++)
    {
        Console.WriteLine($"Таблица кубов от единицы до вашего числа: {i} | {i * i * i}");
    }
}
NumberN(numberN);