// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array = { "1596", "computer", ")))", "-25", "qwerty", ":D", "++" };
void PrintArray(string[] col)
{
    int count = col.Length;
    for (int i = 0; i < count; i++)
    {
        string element = col[i];
        int length = element.Length;
        if (length <= 3) Console.Write($"{col[i]} ");
    }
}
PrintArray(array);
Console.WriteLine();