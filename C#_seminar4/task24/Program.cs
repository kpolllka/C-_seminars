// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1) // если а больше 0, то работает дальше
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i; // или sum +=i - более короткая запись
        }
        return sum; //вернем накопившуюся сумму
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1!");
        return -1; // неправильная сумма (код ошибки)
    }

}

int number = ReadNumber("Введите число А: ");
int summa = SumNumbersFrom1ToA(number);
Console.WriteLine($"Сумма элементов от 1 до А = {summa}");