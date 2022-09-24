/* Задача 14. Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/


Console.WriteLine("Чтобы узнать, является ли число кратным одновременно 7 и 23, введите это число. ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 7;
int num3 = 23;
if (num1 % num2 == 0 && num1 % num3 == 0) Console.WriteLine("Кратно. ");
else Console.WriteLine("Не кратно. ");