// Замена строк на столбцы

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

int[,] NewMatrix(int[,] outArray)
{
    int[,] transp = new int[outArray.GetLength(1), outArray.GetLength(0)];
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for(int j = 0; j < outArray.GetLength(1); j++)
        {
            transp[i,j] = outArray[j,i];
        }
    }
    return transp;
}
Console.Write("Enter numbers of rows m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("New array:");
int[,] matrix = NewMatrix(array);
PrintArray(matrix);
