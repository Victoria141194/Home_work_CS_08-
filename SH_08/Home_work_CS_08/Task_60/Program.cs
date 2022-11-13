// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
Console.Clear();
int[,,] array = GetArray(3, 3, 3, 0, 50);
PrintArray(array);

//..............................МЕТОДЫ....................................

int[,,] GetArray(int length, int height, int depth, int minValue, int maxValue)
{
    int[,,] result = new int[length, height, depth];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}