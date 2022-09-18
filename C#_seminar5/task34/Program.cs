// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int NumberOfEven(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
} 

int[] array = GetArray(10, 100, 999);
Console.WriteLine(String.Join(", ", array));
int numberOfEven = NumberOfEven(array);
Console.WriteLine(numberOfEven);