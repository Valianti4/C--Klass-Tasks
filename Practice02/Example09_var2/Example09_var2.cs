/* Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
Решение с помощью тернарного оператора.
*/


Console.WriteLine("Чтобы узнать наибольшую цифру числа из диапазона [10, 99], нажмите клавишу Enter. ");
Console.ReadLine();
int num = new Random().Next(10, 100);
int firstDigit = num / 10;
int secondDigit = num % 10;
string res = firstDigit == secondDigit ? "цифры равны"
: firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
Console.WriteLine($"Наибольшая цифра числа {num} -> {res}. ");