/* Задача 2. Напишите программу, которая на вход принимает два числа
и проверяет, является ли первое число квадратом второго.
Например:
a = 25, b = 5 -> да;
a = 2, b = 10 -> нет;
a = 9, b = 3 -> да;
a = -3, b = 9 -> нет;
*/


Console.Write("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a == b * b) Console.Write($"Число {a} является квадратом числа {b}. ");
else Console.Write($"Число {a} не является квадратом числа {b}. ");