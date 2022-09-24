// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Message(string message)
{
    Console.Write(message);
    return (Convert.ToDouble(Console.ReadLine()));
}

double b1 = Message ("Введите координату b1: ");
double k1 = Message ("Введите координату k1: ");
double b2 = Message ("Введите координату b2: ");
double k2 = Message ("Введите координату k2: ");

if (k1 == k2 && b1 != b2)
{
    Console.WriteLine ("Прямые параллельны.");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine ("Прямые совпадают.");
}
else
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты пересечения прямых: x={x}, y={y}");
}