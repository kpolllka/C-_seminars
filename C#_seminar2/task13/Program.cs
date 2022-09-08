// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (100 <= number && number <= 999)
{
    int result = number % 10;
    Console.WriteLine(result);
}

while (1000 <= number && number <= -1000)
{
    number = number / 10;
    
        
        }
        else if (-100 <= number && number <= -999)
        {
            int result2 = number % 10;
            Console.WriteLine(result2);
        }
}
if (-100 < number && number < 100)
{
    Console.WriteLine("Третьй цифры нет");
}



