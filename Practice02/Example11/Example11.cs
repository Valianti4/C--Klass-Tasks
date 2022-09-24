/* Задача 11. Напишите программу, которая выводит 
трёхзначное случайное число и удаляет
вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/


Console.Write("Для вывода случайного трёхзначного положительного числа, нажмите клавишу Enter. ");
Console.Read();
int num = new Random().Next(100, 1000);
Console.WriteLine($"{num}");
int temp1 = num / 100;
int temp2 = temp1 * 10;
int temp3 = num % 10;
int res = temp2 + temp3;
Console.Write($"Это число без второй цифры: {res}. ");