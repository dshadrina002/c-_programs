// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SelectionSort(int[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for(int j = 0; j < outArray.GetLength(1); j++)
        {
            int maxIndex = j;
            for(int k = j+1; k < outArray.GetLength(1); k++)
            {
                if(outArray[i,k] > outArray[i,maxIndex]) maxIndex = k;
            }
            int temporary = outArray[i,j];
            outArray[i,j] = outArray[i,maxIndex];
            outArray[i,maxIndex] = temporary;
        }
    }
}
Console.Write("Enter numbers of rows m: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SelectionSort(array);
Console.WriteLine("New array:");
PrintArray(array);