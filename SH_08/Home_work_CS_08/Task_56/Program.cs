// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int[,] array = GetArray(4, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] sumElementsFromRows = SumOfElements(array);
NumberRow(sumElementsFromRows);

//..............................МЕТОДЫ....................................

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumOfElements(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
    }
    return result;
}


void NumberRow(int[] array)
{
    int number = 0;
    int min = array[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (min > array[i]) 
        {
            min = array[i];
            number = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {number + 1} строка");
}