// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfDigit(int num)
{
    int count = 0; //число цифр (кол-во итераций цикла)
    if (num == 0) count = 1;
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int number = ReadNumber("Введите число: ");
int count = GetCountOfDigit(number);
Console.WriteLine($"Введенное число {number} состоит из {count} цифр");