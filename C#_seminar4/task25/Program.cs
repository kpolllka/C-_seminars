// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 1)
Console.WriteLine ("Введено не верное число B");

else
{
    int mult = A;
    for (int i = 1; i < B; i++)
    {
        mult = mult * A;
    }
    Console.WriteLine($"{A} в степени {B} = {mult}");
}