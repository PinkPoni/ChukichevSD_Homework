// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
string SetCounts() //Метод для ввода чисел
{
Console.Write("Введите любое количество чисел: ");
string numbers = Console.ReadLine();
return numbers;
}
string counts = SetCounts();

int SplitCounts() // Метод для удаления запятых и пробелов из введенного текста, 
                  //преобразование его в числовой массив, и нахождения количества чисел больше ноля.
{
char[] separators = new char[] { ' ', ',' };
string[] NumbersText = counts.Split(separators, StringSplitOptions.RemoveEmptyEntries);
int [] NumbersCount = new int[NumbersText.Length];
for (int i = 0; i < NumbersCount.Length; i++)
{
    string num = NumbersText[i];
    int count = Convert.ToInt32(num);
    NumbersCount[i] = count;
}
int quantity = 0;
for (int i = 0; i < NumbersCount.Length; i++)
{
    quantity += NumbersCount[i] > 0 ? 1 : 0;
}
return quantity;
}
int result = SplitCounts();
Console.WriteLine($"Количество чисел болше ноля: {result}");