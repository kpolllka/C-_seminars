// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// Данные вводятся с консоли пользователем.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int a1 = ReadNumber("Введите число: ");
int a2 = ReadNumber("Введите число: ");
int a3 = ReadNumber("Введите число: ");
int a4 = ReadNumber("Введите число: ");
int a5 = ReadNumber("Введите число: ");
int a6 = ReadNumber("Введите число: ");
int a7 = ReadNumber("Введите число: ");
int a8 = ReadNumber("Введите число: ");

int[] array = {a1, a2, a3, a4, a5, a6, a7, a8};
Console.WriteLine(string.Join(", ", array));