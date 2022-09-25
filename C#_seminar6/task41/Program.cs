// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// string Message (string message)
// {
// Console.Write(message);
// return Console.ReadLine()!;
// }

// string N = Message ("Введите чило, для прекращения ввода введите stop: ");

// int count = 0;
// while (N != "stop")
// {
//     int i = Convert.ToInt32(N);
//     if (i > 0)
//     {
//         count = count + 1;
//         N = Message("Введите чило, для прекращения ввода введите stop: ");
//     }
//     else
//     {
//         N = Message("Введите чило, для прекращения ввода введите stop: ");
//     }
// }
// Console.WriteLine($"Вы ввели {count} чисел больше 0");

string ReadNumber(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int countOfPositive = 0;

while (true)
{
    string answer = ReadNumber("Введите число: ");
    if (answer == "stop")
    {
        break;
    }
    else
    {
        // int answerNumber = Convert.ToInt32(answer); - переменная не нужна, если делаем Парс
        int.TryParse(answer, out int answerNumber);
        if (answerNumber > 0)
        {
            countOfPositive++;
        }
    } 
}
Console.WriteLine(countOfPositive);