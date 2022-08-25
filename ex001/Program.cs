// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
       {
        count++;
       }
}
Console.WriteLine($"{count} чисел больше 0");