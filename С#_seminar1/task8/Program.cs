// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число больше 0: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

while(count <= N && count % 2 == 0)
{
    Console.Write(count + " ");
    count = count + 2;
}
if(N <= 1)
Console.WriteLine("Невозможно получить цепочку четных положительных чисел до введенного числа");