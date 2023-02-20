// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
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
double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(min, max + 1) + random.NextDouble();
        }
    }
    return matrix;
}
void Print(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}
var matrix = GetMatrix(numRows, numColumns, numMin, numMax);
Print(matrix);