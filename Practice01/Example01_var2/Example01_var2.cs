/* Напишите программу, которая на вход принимает число
и выдаёт его квадрат (число умноженное само на себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/


Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
double square = a * a; 
Console.Write($"Квадрат числа {a} равен {square}. ");