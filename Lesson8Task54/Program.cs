// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void Sorting(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (j != 0 && massive[i, j] > massive[i, j - 1])
            {
                for (; j >= 1; j--)
                {
                    int temp = massive[i, j - 1];
                    massive[i, j - 1] = massive[i, j];
                    massive[i, j] = temp;
                }

            }
        }

    }
}

var matrix = GetMatrix(numRows, numColumns, numMin, numMax);
Print(matrix);
Console.WriteLine();
Sorting(matrix);
Print(matrix);
Console.WriteLine();