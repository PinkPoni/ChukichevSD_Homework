// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Print(matrix);

double Summ (double numberColumns) // Метод выводит сумму по заданной колонке
{
int sumColumns = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == numberColumns) sumColumns += matrix[i, j];
        }

    }
return sumColumns;
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (double columns = 0; columns < numColumns; columns++)
{
    double average = Summ(columns) / numRows;
    Console.Write(average + " ");
}
Console.WriteLine();