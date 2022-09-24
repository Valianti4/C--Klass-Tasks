/* Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/


Console.WriteLine("Чтобы узнать наибольшую цифру числа из диапазона [10, 99], нажмите клавишу Enter. ");
Console.ReadLine();
int num = new Random().Next(10, 100);
int firstDigit = num / 10;
int secondDigit = num % 10;

if (firstDigit == secondDigit) Console.WriteLine("Цифры равны. ");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {num} равна {firstDigit}. ");
else Console.WriteLine($"Наибольшая цифра числа {num} равна {secondDigit}. ");