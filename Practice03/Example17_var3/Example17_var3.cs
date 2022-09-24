﻿/* Напишите программу, которая принимает на вход
координаты точки (x и y), причём x !=0 и y !=0 и
выдаёт номер четверти плоскости, в которой находится эта точка.
Решение с помощью метода.
*/

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть.";
    if (xc < 0 && yc > 0) return "Вторая четверть.";
    if (xc < 0 && yc < 0) return "Третья четверть.";
    if (xc > 0 && yc < 0) return "Четвёртая четверть.";
    return "Введены некорректные координаты.";
}

int i = 0;
string[] arr = new string[5];
while (i < arr.Length)
{
    Console.WriteLine($"Введите координаты точки {i + 1}: ");
    Console.Write("x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    string res = GetQuarter(x, y);
    Console.WriteLine(res);
    i++;
}