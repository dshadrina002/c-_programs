// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for(int i = 0; i<m ; i++)
    {
        for(int j = 0; j<n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return res;
}

void PrintArray(int [,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0) ; i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    if (columns1 != rows2)
    {
        Console.WriteLine("Matrices cannot be multiplied, columns of matrix1 must equal rows of matrix2");
        return;
    }

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    PrintArray(result);
}

int rows = 2;
int columns = 2;

int[,] matrix1 = GetArray(rows, columns, 0, 10);
Console.WriteLine("Your Matrix 1 is");
PrintArray(matrix1);
int[,] matrix2 = GetArray(rows, columns, 0, 10);
Console.WriteLine("Your Matrix 2 is");
PrintArray(matrix2);
Console.WriteLine("Your Matrix multiplication is");
MultiplyMatrices(matrix1, matrix2);