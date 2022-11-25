﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N == 0)
{
Console.WriteLine("Неверное число, оно равно нулю");
N = Convert.ToInt32(Console.ReadLine());
}

if (N>0)
 for (int i = 1; i <= (N); i++)
{
Console.WriteLine($"Квадрат {i}: {Math.Pow(i, 2)}");
}
else
for (int i = 1; i >= N; i--)
{
Console.WriteLine($"Квадрат {i}: {Math.Pow(i, 2)}");
}