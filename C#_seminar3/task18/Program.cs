// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер координатной четверти: ");
int N = Convert.ToInt32(Console.ReadLine());


if ( 1 <= N && N <= 4) //делаем проверку на правильность введенного условия
{
    if (N == 1)
    {
        Console.WriteLine("Диапазон возможных координат указанной четверти x > 0 && y > 0");
    }
    if (N==2)
    {
        Console.WriteLine("Диапазон возможных координат указанной четверти x < 0 && y > 0");
    }        
    if (N==3)
    {
        Console.WriteLine("Диапазон возможных координат указанной четверти x < 0 && y < 0");
    }
    if (N==4)
    {
        Console.WriteLine("Диапазон возможных координат указанной четверти x > 0 && y < 0");
    }
}
else
{
    Console.WriteLine($"Введенного номера четверти {N} не существует");
}