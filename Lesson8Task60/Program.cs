// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int SetNumber(string numberName)
{
    Console.Write($"Введите {numberName} ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int numRows = SetNumber("количество строк: ");
int numColumns = SetNumber("количество колонок: ");
int numDepth = SetNumber("количество рядов: ");
int numMax = SetNumber("максимальное число: ");
int numMin = SetNumber("минимальное число: ");

int[,,] GetMatrix(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    var random = new Random();
    int pos = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int l = 0; l < depth; l++)
            {
                matrix[i, j, l] = random.Next(min, max + 1);
                pos++;
            }

        }
    }
    return matrix;
}

void Print(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i, j, l]} ({i}, {j}, {l}) ");
            }
        Console.WriteLine();
        }
    }
}

var matrix = GetMatrix(numRows, numColumns, numDepth, numMin, numMax);

Print(matrix);
Console.WriteLine();