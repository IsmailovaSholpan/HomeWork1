﻿// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число больше 1: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num > 1)
{
    while (count <= num)
    {
        Console.Write($" {count};");
        count = count + 2;
    };
}
else { Console.Write("Ошибка, введите число больше 1!"); }