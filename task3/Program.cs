// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива2: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива2: ");
int columns2 = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

int[,] array2 = GetArray(columns, columns2);
PrintArray2(array2);
Console.WriteLine();

int[,] resultMatrix = GetArray(rows, columns2);
MultiplyMatrix(array, array2, resultMatrix);
Console.WriteLine($"\nРезультирующая матрица будет:");
PrintArray(resultMatrix);


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

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
void PrintArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] array, int[,] array2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}