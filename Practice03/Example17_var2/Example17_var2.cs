/* Задача 17. Напишите программу, которая принимает на вход
координаты точки (x и y), причём x !=0 и y !=0 и
выдаёт номер четверти плоскости, в которой находится эта точка.
Решение с помощью метода.
*/


Console.WriteLine("Введите координаты точки: ");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть.";
    if (xc < 0 && yc > 0) return "Вторая четверть.";
    if (xc < 0 && yc < 0) return "Третья четверть.";
    if (xc > 0 && yc < 0) return "Четвёртая четверть.";
    return "Введены некорректные координаты.";
}

string res = GetQuarter(x, y);
Console.WriteLine(res);