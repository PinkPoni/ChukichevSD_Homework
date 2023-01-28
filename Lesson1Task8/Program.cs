//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
double number = 24;
double count = 1;
while (count <= number)
{
    if (count%2 == 0)
{
    Console.WriteLine(count);
    count++;
}
else
{
    count++;
}
}