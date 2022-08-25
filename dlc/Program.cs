Console.Clear();
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Convert.ToString(a, 2));

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Первый метод


// Console.WriteLine(arr);
// Console.Write("Введите конец диапазона от 1 до : ");
// int end = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int j = 1;
// Console.Write(a + " ");
// for (int i = 1; i <= end; i += j)
// {
//     Console.Write(i+ " ");
//     j = i - j;
// }

// Второй метод


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int c = 0;
// int a = 0;
// int b = 1;
// Console.Write($"|{a}||{b}|");
// while (number > c)
// {
//     c = a + b;

//     Console.Write($"|{c}|");

//     a = b;
//     b = c;
// }
// Console.WriteLine();


// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// Console.WriteLine("Введите длину массива");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите диапозон чисел от");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите диапозон чисел до");
// int end = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// for (int i = 0; i < N; i++)
// {
//     array[i] = new Random().Next(start, end + 1);
//     Console.Write($"|{array[i]}|");
// }
// Console.WriteLine();
