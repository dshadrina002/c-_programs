// поменять местами первую и последнюю строки массива

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

void ReverseArray(int[,] outArray) // переставляем с пправа на лево
{
    for(int j = 0; j<outArray.GetLength(1); j++)
    {
        int k = outArray[0,j];
        outArray[0,j] = outArray[outArray.GetLength(0)-1,j];
        outArray[outArray.GetLength(0)-1,j] = k;
    }
}

Console.Write("Enter numbers of rows m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
Console.WriteLine("New array:");
PrintArray(array);

