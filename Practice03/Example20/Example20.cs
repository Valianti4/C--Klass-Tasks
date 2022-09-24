/* Задача 20: Напишите программу, 
которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1), -> 5.09
A (7,-5); B (1,-1) -> 7.21
*/


Console.WriteLine("Введите координату x для точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
Console.Write("Расстояние между точками равно: ");
Console.WriteLine(Math.Round(res, 2, MidpointRounding.ToZero));