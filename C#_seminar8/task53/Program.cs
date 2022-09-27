// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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

void NewMatrix(int[,] matrix)
{
        for(int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;           
    }
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine();
NewMatrix(matr);
PrintMatrix(matr);