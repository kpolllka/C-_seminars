// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000); // Вывод числа от 100 до 999
Console.WriteLine($"Сгенерировано случайное число {number}");

int digit3 = number % 10; // получим третью цифру числа
int digit1 = number / 100; // получим первую цифру числа т.е. перем. ште целая, ост. от деления не будет
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);

//Console.WriteLine($"{digit1}{digit3}");
System.Console.WriteLine("Новое число "+ digit1 + digit3);