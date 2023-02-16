//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int SetCount(string number)
{
Console.Write($"Введите {number} ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}
int [] GetArray(int size, int minValue, int maxValue)
{
	int[] res = new int[size];
	for (int i = 0; i < size; i++)
	{
		res[i] = new Random().Next(minValue, maxValue+1);
	}
	return res;

}

int numarray = SetCount("количество элементов массива: ");
int [] array = GetArray(numarray,100,999);
Console.WriteLine(String.Join(", ", array));
double EvenSum = 0;
foreach (var el in array)
{
EvenSum += el%2 == 0 ? 1 : 0;
}
Console.Write($"Количество четных чисел в массиве: {EvenSum} ");