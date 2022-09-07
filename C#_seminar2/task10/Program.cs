// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (100 <= number && number <= 999)
{
    int count = number % 100;
    int count2 = count / 10;
    Console.WriteLine(count2);
}
else
Console.WriteLine("Введено не трехзначное число!");