// sum of elemnt on main diagonal

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

void GetSumMain(int[,] outArray)
{
    int sum = 0;
    for(int i = 0; i<outArray.GetLength(0) ; i++)
    {
        for(int j = 0; j<outArray.GetLength(1); j++)
        {
            if(i==j) 
            {
                sum = sum + outArray[i,j];
            }
        }
    }
    Console.WriteLine($"Sum of elements on main diagonale = {sum}");    
}

Console.Write("Enter numbers of rows m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
GetSumMain(array);
