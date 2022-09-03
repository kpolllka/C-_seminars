// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = -number1;

while(number2 <= number1)
{
    Console.Write(number2 + " ");
    number2 = number2 + 1;
}
if(number1 < 0)
{
    Console.WriteLine("Введено не положительное цисло!");
}