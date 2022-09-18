﻿// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}


int[] array = GetArray(5, 0, 100);
Console.WriteLine($"Исходрный массив = {String.Join(", ", array)}");
ReverseArray(array);
Console.WriteLine($"Развернутый массив = {String.Join(", ", array)}");