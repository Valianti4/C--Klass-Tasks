/* Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
Решение с помощью метода.
*/


Console.WriteLine("Чтобы узнать наибольшую цифру числа из диапазона [10, 99], нажмите клавишу Enter. ");
Console.ReadLine();
int num = new Random().Next(10, 100);

int MaxDigit(int a)
{
    int firstDigit = a / 10;
    int secondDigit = a % 10;
    if (firstDigit == secondDigit) return 0;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit; 
    return result;
}

int result = MaxDigit(num);
string res = result == 0 ? "Цифры равны" : result.ToString();
Console.WriteLine($"Наибольшая цифра числа {num} -> {res}. ");