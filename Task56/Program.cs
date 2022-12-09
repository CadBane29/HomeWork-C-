// Задача 56: Задайте прямоугольный двумерный массив. 
// 1. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,3}", matrix[i, j]);
            Console.Write(j < matrix.GetLength(1) - 1 ? ","
                          : string.Empty);
        }
        Console.Write(" |\n");
    }
}

int SearchSumFirtsRow(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[0,i];
    }
    return sum;
}

int SearchMinSumRowMatrix(int[,] matrix)
{
    int sumFirstRow = SearchSumFirtsRow(matrix);
    int minSumRow = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if(sum < sumFirstRow)
        {
            sum = sumFirstRow;
            minSumRow = i;
        }
    }
    return minSumRow;
}


int[,] matrix = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix);
int minSumElementRowMatrix = SearchMinSumRowMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {minSumElementRowMatrix + 1} строке.");