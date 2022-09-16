// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(a) < 10)
Console.WriteLine($"Сумма цифр во введенном числе = {Math.Abs(a)}");

else
{
    int sum = 0;
    
    for (int i = 0; Math.Abs(a) > 0; i++)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    Console.WriteLine($"Сумма цифр во введенном числе = {Math.Abs(sum)}");
}

