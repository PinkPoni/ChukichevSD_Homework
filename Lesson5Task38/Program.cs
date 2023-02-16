// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int SetCount(string number)
{
Console.Write($"Введите {number} ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}
double [] GetArray(int size)
{
	double [] res = new double[size];
	for (int i = 0; i < size; i++)
	{
		res[i] = new Random().NextDouble();
	}
	return res;
}

int numarray = SetCount("количество элементов массива: ");
double [] array = GetArray(numarray);
Console.WriteLine(String.Join(", ", array));
double ElMax = array[0];
double ElMin = array[0];
for (int i = 0; i < numarray; i++)
{
    ElMax = array[i] > ElMax ? array[i] : ElMax;
    ElMin = array[i] < ElMin ? array[i] : ElMin;
}

Console.Write($"Разница между максимальным и минимальным элементами массива: {ElMax-ElMin} ");