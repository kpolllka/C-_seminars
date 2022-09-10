// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите положительное число больше 0: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= N)
{
    Console.Write(Math.Pow(count, 2) + " ");
    count ++;
}
if (N < 1)
{
    Console.WriteLine("Введенное число не соответствует условию.");
}