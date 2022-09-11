// Написать метод для разворота массива,
// не используя память под дополнительный массив.

int[] array = {5, 8, 7, 9, 4};         // массив
int n = array.Length;                  // длина массива
int i = 0;                             // индекс массива

while(i < n/2)
{
    
    int t = array[i];                  // переменная для записи промежуточных значений
    array[i] = array[n-1-i];
    array[n-1-i] = t;
    i++;
}
Console.WriteLine(string.Join(", ", array));