//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int number1 = 1, number2 = 6, number3 = 4;
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write("max = ");
        Console.WriteLine(number1);
    }   
    else 
    {
        Console.Write("max = ");
        Console.WriteLine(number3);
    } 
}
else
{
    if (number2 > number3)
    {
        Console.Write("max = ");
        Console.WriteLine(number2);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(number3);
    }
}