/* Задача 17. Напишите программу, которая принимает на вход
координаты точки (x и y), причём x !=0 и y !=0 и
выдаёт номер четверти плоскости, в которой находится эта точка.
*/


Console.WriteLine("Введите координаты точки: ");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Первая четверть. ");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть. ");
else if (x < 0 && y < 0) Console.WriteLine("Третья четверть. ");
else if (x > 0 && y < 0) Console.WriteLine("Четвёртая четверть. ");
else Console.WriteLine("Введены некорректные координаты. ");