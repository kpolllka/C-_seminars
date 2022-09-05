// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
        Console.WriteLine ("Кратно");
}
else
{
    int remainder = num1 % num2;
    Console.WriteLine($"Не кратно, остаток от деления {remainder}");
    //Console.WriteLine($"Не кратно, остаток от деления {num1%num2}"); - второй вариант вывода, без
    //ввода новой переменной
}
