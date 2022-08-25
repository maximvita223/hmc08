// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Clear();
Console.Write("Введите K1: ");
double k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите B1: ");
double b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите K2: ");
double k2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите B2: ");
double b2 = int.Parse(Console.ReadLine() ?? "0");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"точка пересечения{x:f2} и {y:f2} ");
