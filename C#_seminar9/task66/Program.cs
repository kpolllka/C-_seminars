// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMtoN(int m, int n)
{
    if(m > n || m <=0)
    {
        return;
    }
    else
    {
        PrintMtoN(m, n-1);
        Console.Write(n + " ");
    }
}

int num1 = ReadNumber("Введите число M: ");
int num2 = ReadNumber("Введите число N: ");
PrintMtoN(num1, num2);