// Задача 58: Задайте две матрицы. Напишите программу, 
// 1. которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write("{0,4}", matrix[i, j]);
            Console.Write(j < matrix.GetLength(1) - 1 ? ","
                        : string.Empty);
        }
        Console.Write(" |\n");
    }
}

bool MatrixEqualityCheck(int[,] matrix, int[,] matrix2)
{
    return matrix.GetLength(0) == matrix2.GetLength(0)
    && matrix.GetLength(1) == matrix2.GetLength(1);
}

int[,] MatrixMultiplication(int[,] matrix, int[,] matrix2)
{
    int[,] multiMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                multiMatrix[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return multiMatrix;
}

int[,] matrix = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix2);
bool check = MatrixEqualityCheck(matrix, matrix2);
int[,] multiMatrix = MatrixMultiplication(matrix, matrix2);
Console.WriteLine();
if (check == true) PrintMatrix(multiMatrix);
else Console.WriteLine("Размеры матриц указаны неверно!");

