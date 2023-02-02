Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
if (count < 100) 
{
    Console.WriteLine("Во введенном числе отсутствует третья цифра");
}
else 
{
while (count > 999)
{
    count = count / 10;
}
Console.WriteLine($"Третья цифра в числе - {count % 10}");
}