// Задайте массив.
// Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// На экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

// true - есть элемент в массиве
// false - элемент в массиве отсутствует
bool FindNumber(int[] arr, int findNumber)
{
    bool isNumberInArray = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            isNumberInArray = true;
        }
    }
    return isNumberInArray;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int find = ReadNumber("Введите число: ");
bool res = FindNumber(array, find);
if (res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}