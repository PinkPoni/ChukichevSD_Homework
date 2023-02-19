// Задача 44:выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1
// Если N = 7 --> 0 1 1 2 3 5 8
Console.Write("Введите номер числа Фибонначи: ");
int numberfibo = Convert.ToInt32(Console.ReadLine());
int numberfiboall = numberfibo-2;
int numberfibo1 = 0;
int numberfibo2 = 1;
int numberbeforeprevious = 0;
int numberprevious = 1;
Console.Write($"{numberfibo1}, ");
Console.Write($"{numberfibo2}");
for (int i=0; i < numberfiboall; i++)
{
    int num = numberprevious + numberbeforeprevious;
    numberbeforeprevious = numberprevious;
    numberprevious = num;
    Console.Write($", "+$"{num}");
}
Console.WriteLine();