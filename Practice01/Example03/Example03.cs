/* Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/


Console.WriteLine("Чтобы узнать, какому числу соответствует день недели, введите целое число в диапазоне от 1 до 7. ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7)
{ 
    Console.WriteLine("Вы ввели неверное число. Пожалуйста, введите целое число в диапазоне от 1 до 7. ");
}
else
{
    if (num == 1) Console.Write("Понедельник. ");
    if (num == 2) Console.Write("Вторник. ");
    if (num == 3) Console.Write("Среда. ");
    if (num == 4) Console.Write("Четверг. ");
    if (num == 5) Console.Write("Пятница. ");
    if (num == 6) Console.Write("Суббота. ");
    if (num == 7) Console.Write("Воскресенье. ");
} 