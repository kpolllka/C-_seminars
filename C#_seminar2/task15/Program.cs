// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (0 <day && day < 6 )
{
     Console.Write($"{day} день недели не выходной");
}
else if (6 <= day && day <=7)
{
     Console.Write($"{day} день недели выходной");
}
else Console.WriteLine ($"{day} дня недели не существует");