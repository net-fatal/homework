﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: "!);
int num = int.Parse(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine($"Число {num} является нечетным");
}
 else
{
    Console.WriteLine($"Число {num} является четным");
}
