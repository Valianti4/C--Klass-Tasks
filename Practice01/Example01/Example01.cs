/* Напишите программу, которая на вход принимает число
и выдаёт его квадрат (число умноженное само на себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.Write("Введите целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
if (int.TryParse(Console.ReadLine(), out int a))
{
    int square = a * a; 
    Console.Write($"Квадрат числа {a} равен {square}. ");
}
else
{
    Console.WriteLine("Это число не является целым. Пожалуйста, введите целое число. "); 
}