// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());

if (-99 > N || N > 99)
{
    
    while (-1 > N || N > 1)
    {
        N = N / 10;
    }
    double N2 = Math.Truncate(N * 1000 % 10);
    Console.WriteLine(N2);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}


// Console.WriteLine("Введите число");
// int NumberA = Convert.ToInt32(Console.ReadLine());
// if(NumberA < 100)
// {
//     Console.WriteLine($"у числа {NumberA} нет третьей цифры");
// }
// else
// while(NumberA > 999)
// {
//     NumberA = NumberA / 10;
// }
//  if(NumberA < 1000)
// {
//     Console.WriteLine(NumberA % 10);
// }