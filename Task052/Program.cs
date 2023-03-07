// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] res = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            res[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void GetSumAvg(int[,] inArray)
{
    for(int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        double avg = 0;
        for(int i = 0; i < inArray.GetLength(0); i++)
        {
            sum = sum + inArray[i,j];
        }
        avg = sum / inArray.GetLength(0);
        Console.Write($"{sum};{avg} ");
    }
}

Console.Write("Enter numbers of rows m: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int column = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, column, 0, 10);
PrintArray(array);
GetSumAvg(array);