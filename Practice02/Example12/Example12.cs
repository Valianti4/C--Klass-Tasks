﻿/* Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16 -> 4 кратно
*/


Console.WriteLine("Чтобы увидеть, является ли второе число кратным первому, введите первое число. ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число. ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0) Console.WriteLine("Кратно. ");
else
{ 
    int res = num2 % num1;
    Console.WriteLine($"{num1} не кратно {num2}, остаток {res}. ");
}