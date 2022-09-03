﻿// 7. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (100 <= number && number <= 999)
{
    int count = number % 10;
    Console.WriteLine(count);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}