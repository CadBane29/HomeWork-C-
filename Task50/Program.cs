// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

bool FindIndexMatrix(int[,] matrix, int rowIndex, int columnIndex)
{
    if (rowIndex < 0 || columnIndex < 0) return false;
    if (rowIndex >= matrix.GetLength(0) || columnIndex >= matrix.GetLength(1)) return false;
    else return true;
}

Console.Write("Пользователь, введите интересующий индекс строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите интересующий индекс столбца: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(5, 6, -10, 10);
PrintMatrix(matrix);
bool findIndexMatrix = FindIndexMatrix(matrix, rowIndex, columnIndex);
Console.WriteLine(findIndexMatrix ?
$"В строке № {rowIndex} и столбце № {columnIndex}, искомое число: {matrix[rowIndex, columnIndex]}"
: "Введите другие значения строк и столбцов!");

