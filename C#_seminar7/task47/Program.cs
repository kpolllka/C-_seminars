// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5    7    -2    -0,2
// 1    -3,3    8    -9,9
// 8     7,8  -7,1     9


int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columnCounts, int leftRange, int rightRange)

{
    double[,] matrix = new double[rowsCount, columnCounts];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(((rand.NextDouble() * (rightRange-leftRange) + leftRange)), 2);
            // (rightRange-leftRange) + leftRange - диапазон чисел, значения max и min значений массива
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int min = ReadNumber("Введите максимальное отрицалельное значение массива: ");
int max = ReadNumber("Введите максимальное значение массива: ");
double[,] matr = GetMatrix(m, n, min, max);
PrintMatrix(matr);
