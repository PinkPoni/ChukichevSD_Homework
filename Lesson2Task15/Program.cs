Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7) 
{
    Console.WriteLine("Выходной");
}
else 
{
    Console.WriteLine("Рабочий день");
}