// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();
int rows = 4;
int columns = 4;

int[,] array = new int[rows, columns];
int num = 1;
int i = 0;
int j = 0;

while (num <= rows * columns)
{
    array[i, j] = num;
    if (i < j && i + j >= rows - 1) ++i;
    else if (i <= j + 1 && i + j < rows - 1) ++j;
    else if (i >= j && i + j > rows - 1) --j;
    else --i;
    ++num;
}

PrintArray(array);
//..............................МЕТОДЫ....................................

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
