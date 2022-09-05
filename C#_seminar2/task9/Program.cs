// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировано случайное число {number}");

int digit2 = number % 10; // получим последнюю цифру числа
int digit1 = number / 10; // получим первую цифру числа т.е. перем. ште целая, ост. от деления не будет
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
if (digit1 > digit2)
{
    Console.WriteLine($"Цифра {digit1} больше цифры {digit2}");
}
else if(digit1 < digit2)
{
    Console.WriteLine($"Цифра {digit2} больше цифры {digit1}");
}
else
{
    Console.WriteLine($"Цифры {digit1} и {digit2} равны друг другу");
}