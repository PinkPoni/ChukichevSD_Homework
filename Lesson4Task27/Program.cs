// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
int sum (int number)
{
    int result = 0;
    for (number = 0; count > 0;)
    {
    number = count % 10;
    result = result + number;
    count = count / 10;
    }
    return(result);
}
Console.WriteLine(sum(count));