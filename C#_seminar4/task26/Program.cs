// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

// if (-10 < N && N < 10)
// {
//     Console.WriteLine ($"Введенное число {N} состоит из 1 цифры");
// }
if (Math.Abs(N) > 9)
{
    int i = 0;
    while (i < Math.Abs(N) && Math.Abs(N) > 9)
    {
        N = N / 10;
        i++;
    }
    Console.WriteLine ($"Введенное число состоит из {i+1} цифр");
}
else
Console.WriteLine($"Введенное число состоит из 1 цифры");