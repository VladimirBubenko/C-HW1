// Домашнее задание 1

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"max = {max} min = {min}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.Write("max = " + max);