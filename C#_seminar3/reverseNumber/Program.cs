// разворот числа

int number = 12345; // исходное число
int tempNumber = number; //число, которое мы будем делить на 10
int reversedNumber = 0; //развернутое число

while(tempNumber > 0)
{
    int digit = tempNumber % 10;
    reversedNumber = reversedNumber * 10 + digit;
    tempNumber = tempNumber / 10;
}
Console.WriteLine($"Развернутое число равно {reversedNumber}");
