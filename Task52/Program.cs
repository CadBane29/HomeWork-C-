// Задача 52. Задайте двумерный массив из целых чисел. 
// 1. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}| ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

double[] AverageMatrixColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average[j] += matrix[i, j];
        }
        average[j] = Math.Round(average[j] / matrix.GetLength(0), 1);
    }
    return average;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],3}; ");
        else Console.Write($"{array[i],3} ");
    }
    Console.WriteLine("]");
}

int[,] matrix = CreateMatrixRndInt(5, 7, 1, 11);
PrintMatrix(matrix);
Console.WriteLine();
double[] averageColumnsArray = AverageMatrixColumns(matrix);
PrintArrayDouble(averageColumnsArray);
Console.WriteLine("Среднее арифмитическое значение в каждого столбца.");