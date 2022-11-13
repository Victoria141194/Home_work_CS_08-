//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.Write("Введите количество строк первого массива: ");
int rowsA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов первого массива: ");
int columnsA = int.Parse(Console.ReadLine() ?? "");

int[,] arrayA = GetArray(rowsA, columnsA, 0, 9);
Console.WriteLine("Матрица А: ");
PrintArray(arrayA);

Console.Write("Введите количество строк второго массива: ");
int rowsB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов второго массива: ");
int columnsB = int.Parse(Console.ReadLine() ?? "");

int[,] arrayB = GetArray(rowsB, columnsB, 0, 9);
Console.WriteLine("Матрица B: ");
PrintArray(arrayB);


Console.WriteLine();
if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        Console.WriteLine("Умножение невозможно!");
    }
else Console.WriteLine("Результирующая матрица: ");
PrintArray(GetMatrixMultiplication(arrayA, arrayB));

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


int[,] GetMatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i, j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
