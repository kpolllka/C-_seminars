﻿// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите положительное число больше 0: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}
else
{
    Console.WriteLine("Введенное число не соответствует условию.");
}