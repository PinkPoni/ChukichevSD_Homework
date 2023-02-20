// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// В данном решении под позицией элемента понимается его порядковый номер от начала массива, начиная с 1 позиции.
// Например: 6-й элемент, 12-й, 52-й и т.д.
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
int numPos = SetNumber("число - позицию элемента: ");
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

int Position (int numberPos, int numberColumns) // Метод возвращает значение элемента с заданной позиции  
{
int i = numberPos%numberColumns == 0 ? numberPos/numberColumns-1 : numberPos/numberColumns;
int j = numberPos%numberColumns == 0 ? numberColumns-1 : numberPos%numberColumns-1;
int numberPosition = matrix[i, j];  
return numberPosition;  
}

if(numPos>numRows*numColumns)
{
    Console.WriteLine($"Такой позиции элемента в массиве нет! В массиве всего {numRows*numColumns} позиций.");    
}
else
{
    Console.WriteLine($"На {numPos} позиции от начала массива находится число {Position(numPos, numColumns)}");
}