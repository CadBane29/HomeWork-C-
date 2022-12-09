// Задача 60. ...Сформируйте трёхмерный массив
// 1. из неповторяющихся двузначных чисел. Напишите программу, которая 
// 2.будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix3D = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.Write("[");
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write("{0,4}", matrix3D[i, j, k]);
                Console.Write(k < matrix3D.GetLength(2) - 1 ? ","
                             : string.Empty);
            }
            Console.Write(" ]\n");
        }
    }
}

void Print3DMatrix(int[,,]matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix3D = CreateMatrix3DRndInt(2, 2, 2, 10, 99);
PrintMatrix3D(matrix3D);
Console.WriteLine();
Print3DMatrix(matrix3D);

