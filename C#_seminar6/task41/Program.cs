// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string Message (string message)
{
Console.Write(message);
return Console.ReadLine();
}

string N = Message ("Введите чило, для прекращения ввода введите stop: ");

int count = 0;
while (N != "stop")
{
    int i = Convert.ToInt32(N);
    if (i > 0)
    {
        count = count + 1;
        N = Message("Введите чило, для прекращения ввода введите stop: ");
    }
    else
    {
        N = Message("Введите чило, для прекращения ввода введите stop: ");
    }
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");