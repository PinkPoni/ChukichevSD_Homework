// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int SetNumber(string numberName)
{
    Console.Write($"Введите {numberName} ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int numRows = SetNumber("количество строк: ");
int numColumns = SetNumber($"количество колонок не равное {numRows}: ");
if (numColumns == numRows)
{
    Console.WriteLine("Количество колонок введено не верно!"); 
    return;
}
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

int Summ(int numberRows) // Метод выводит сумму по строкам
{
    int numRows = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == numberRows) numRows += matrix[i, j];
        }

    }
    return numRows;
}

Console.Write("Номер строки с наименьшей суммой элементов: ");
int min = Summ(0);
int minLine = 1;
for (int Rows = 0; Rows < numRows; Rows++)
{
    if (Summ(Rows) < min)
    { 
        min = Summ(Rows);
        minLine = Rows+1; 
    }
}
Console.Write(minLine);
Console.WriteLine();