// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverageColymns(int[,] matrix)
{
        for(int j = 0; j < matrix.GetLength(1); j++)
    {
        float sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
            
        }
        if (j != matrix.GetLength(1) - 1)
        {
            Console.Write($"{Math.Round(sum/matrix.GetLength(0), 2)}; ");
        }
        else
        {
            Console.Write($"{Math.Round(sum/matrix.GetLength(0), 2)}.");
        }
    }
    
}


int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
FindAverageColymns(matr);