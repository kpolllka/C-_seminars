// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int m, int n)
{
    int sum = 0;
    if (n == m && n >=1 && m >= 1)
    {
        return n;
    }
    else if (n > m && n >=1 && m >= 1)
    {
        sum = n + Sum(m, n - 1);
        return sum;
    }
    else
    {
        return -1;
    }
}

int M = ReadNumber("Введите число M: ");
int N = ReadNumber("Введите число N: ");

if (N > M) Console.Write(Sum(M, N));
if (N < M) Console.Write(Sum(N, M));
if (N == M) Console.Write(Sum(N, M));