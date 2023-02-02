Console.WriteLine("Введите трехзначное число: ");
int count = Convert.ToInt32(Console.ReadLine());
int result1 = count / 10;
int result = result1%10;
Console.WriteLine(result);