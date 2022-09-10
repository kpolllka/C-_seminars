// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √ (Ax – Bx)^2 + (Ay – By)^2

Console.Write("Введите координату X точки A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2)); // извлечение корня квадратного
// (внутри скобок возведение в квадрат (можно в куб и т.д.))
Console.WriteLine($"{AB:f2}"); //f2 округлили результат до 2 знаков после запятой