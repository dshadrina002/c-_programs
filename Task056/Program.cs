// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void SumColumns(int[,] outArray)
{
    int sumMin = 0;
    int rowIndex = 0;
    for(int i = 0; i<outArray.GetLength(0) ; i++)
    {
        int sum = 0;
        for(int j = 0; j<outArray.GetLength(1); j++)
        {
            sum = sum + outArray[i,j];
        }
        if(i == 0) sumMin = sum;
        else if(sum < sumMin)
            {
                sumMin = sum;
                rowIndex = i;
            }
    }
    Console.Write($"Row with min sum is {rowIndex}. Sum in row = {sumMin}");
}



Console.Write("Enter numbers of rows m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int columns = int.Parse(Console.ReadLine()!);
if(rows == columns)
{
    Console.Write("Count of colunms should not be equal to count of rows");
}
else
{
    int[,] array = GetArray(rows, columns, 0, 10);
    PrintArray(array);
    SumColumns(array);
}
