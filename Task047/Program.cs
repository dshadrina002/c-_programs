// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for(int i = 0; i<m ; i++)
    {
        for(int j = 0; j<n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue);
            Console.Write($"{res[i,j]} ");
        }
        Console.WriteLine();
    }
    return res;
}

Console.Write("Enter numbers of rows m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, -100, 100);
