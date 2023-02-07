//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int count = Convert.ToInt32(Console.ReadLine());
int number1 = count % 10;
int number2 = (count / 10) % 10;
int number3 = (count / 100) % 10;
int number4 = (count / 1000) % 10;
int number5 = (count / 10000) % 10;
int count1 = (number1 * 10000 + number2 * 1000 + number3 * 100 + number4 * 10 + number5);
if (count1 == count)
{
    Console.Write(count);
    Console.WriteLine(" является палиндромом");
}
else
{
    Console.Write(count);
    Console.WriteLine(" не является палиндромом");
}