// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int SetNumber(string numberName)
{
    Console.Write($"Введите {numberName} ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int numRows = SetNumber("количество строк: ");
int numColumns = SetNumber("количество колонок: ");
int numMax = SetNumber("максимальное число: ");
int numMin = SetNumber("минимальное число: ");

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();
    int pos = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
            pos++;
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

var matrix = GetMatrix(numRows, numColumns, numMin, numMax);
var matrix2 = GetMatrix(numRows, numColumns, numMin, numMax);

Print(matrix);
Console.WriteLine();
Print(matrix2);
Console.WriteLine();

int[,] matrixMultiplication = new int[numRows, numColumns];
for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numColumns; j++)
    {
        for (int l = 0; l < numRows; l++)
        {
            matrixMultiplication[i, j] += matrix[i, l] * matrix2[l, j];
        }
    }
}
Print(matrixMultiplication);
Console.WriteLine();