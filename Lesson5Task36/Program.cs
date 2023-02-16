// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int [] array = GetArray(numarray,0,99);
Console.WriteLine(String.Join(", ", array));
double ElSum = 0;
for (int i = 0; i < numarray; i++)
{
    ElSum += i%2 != 0 ? array[i] : 0;
}

Console.Write($"Сумма элементов, стоящих на нечётных позициях: {ElSum} ");