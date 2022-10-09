// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummNum(int m)
{
    if (m == 0)
    {
        return m;
    }
    else
    {
        // int sum = m % 10 + SummNum(m / 10); // классический вариант записи
        // return sum;
        return m % 10 + SummNum(m / 10);
    }
}

Console.WriteLine (SummNum(ReadNumber("Введите число M: ")));