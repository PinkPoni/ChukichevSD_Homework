//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X1 ");
double pointX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1 ");
double pointY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1 ");
double pointZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2 ");
double pointX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2 ");
double pointY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2 ");
double pointZ2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((pointX1-pointX2),2)+Math.Pow((pointY1-pointY2),2)+Math.Pow((pointZ1-pointZ2),2));
Console.Write("Расстояние между точками ");
Console.WriteLine(distance);
