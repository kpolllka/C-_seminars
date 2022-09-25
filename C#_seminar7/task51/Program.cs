﻿// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие: сделать суммирование в один цикл. Матрица может быть прямоугольный

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t"); // \t - более широкий отступ, можно оставить пробел 
        }
        Console.WriteLine();
    }
}

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int min; // для выяснения, у нас больше столобцов или строк
    if (matrix.GetLength(0) >= matrix.GetLength(1))
    {
        min = matrix.GetLength(1);
    }
    else
    {
        min = matrix.GetLength(0);
    }
    for(int i = 0; i < min; i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
Console.WriteLine(SumMainDiagonal(matr));