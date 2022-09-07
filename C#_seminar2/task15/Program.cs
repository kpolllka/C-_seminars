// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
     Console.Write("Понедельник - не выходной день");
}
else if (number == 2)
{
     Console.Write("Вторник - не выходной день");
}
else if (number == 3)
{
     Console.Write("Среда - не выходной день");
}
else if (number == 4)
{
     Console.Write("Четверг - не выходной день");
}
else if (number == 5)
{
     Console.Write("Пятница - не выходной день");
}
else if (number == 6)
{
     Console.Write("Суббота - выходной день");
}
else if (number == 7)
{
     Console.Write("Воскресенье - выходной день");
}
else
{
    Console.Write("Нет такого дня недели");
}