// Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnCounts, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnCounts];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - позволяет получить число строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) //GetLength(1) - позволяет получить число столбцов
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
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] matrix)
{
    int i = ReadNumber("Введите индекс значения по строке: ");
    int j = ReadNumber("Введите индекс значения по столбцу: ");
    if (i > -1 && i < matrix.GetLength(0) && j > -1 && j < matrix.GetLength(1))
    {
        Console.Write($"{matrix[i,j]}");
    }
    else
    {
        Console.WriteLine("Значения с указанным индексом не существует.");
    }
}


int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
FindElement(matr);