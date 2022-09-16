int[] array = new int [8]; // создали массив на 8 элементов
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 2);
}
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " "); 
// }
Console.WriteLine(string.Join(", ", array));