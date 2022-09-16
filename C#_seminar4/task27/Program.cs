// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(a) < 10)
Console.WriteLine($"Сумма цифр в числе равна {Math.Abs(a)}");

else
{
    int summ = 0;
    int i = 0;
    while (a > 9)
    {
        a = a % 10;
        summ = summ + a;
        i++;
        
    }
    Console.WriteLine(sum);
}