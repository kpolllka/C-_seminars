// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ProdNumbersFromToA(int a)
{
    if (a >= 1) // если а больше 0, то работает дальше
    {
        int num = 1;
        for (int i = 1; i <= a; i++)
        {
            num = num * i; // или sum +=i - более короткая запись
        }
        return num; //вернем накопившееся произведение
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1!");
        return -1; // неправильное произведение (код ошибки)
    }

}

int number = ReadNumber("Введите число А: ");
int summa = ProdNumbersFromToA(number);
Console.WriteLine($"Произведение элементов от 1 до А = {summa}");