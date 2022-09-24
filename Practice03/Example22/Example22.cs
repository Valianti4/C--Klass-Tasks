﻿/* Задача 22. Напишите программу, которая на вход принимает число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4.
*/


Console.WriteLine("Чтобы увидеть все квадраты чисел от 1 до определённого целого положительного числа, пожалуйста, введите это");
Console.WriteLine("число. ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (i > 0)
{
    while (i <= num)
    {
        int res = i * i;
        Console.WriteLine($"{i} {res} ");
        i++;
    }
}
if (num < 1)
{
    Console.WriteLine("Вы ввели неверное число. Пожалуйста, введите число больше 1.");
}