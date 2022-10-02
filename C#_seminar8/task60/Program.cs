// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[] RandomArray (int x, int y, int z)
{
    int len = x * y * z;
    int[] randomArray = new int[len];
    Random rand = new Random();
    randomArray[0] = rand.Next(10, 100);
    for (int i = 1; i < len;)
    {
        int num = rand.Next(10, 100);
        int j;
        for (j = 0; j < i; j++)
        {
            if (num == randomArray[j]) break;
        }
        if (j == i)
        {
            randomArray[i] = num;
            i++;
        }
    }
    return randomArray;
}

void CubeArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rand = new Random((int)DateTime.Now.Ticks);
    int[] randArr = RandomArray(x, y, z);
    for(int i = 0, n = 0; i < array.GetLength(0) || n < x * y * z; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++, n++)
            {
                array[i, j, k] = randArr[n];
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
CubeArray(2, 2, 2);