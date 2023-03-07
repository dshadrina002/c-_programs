// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void GetIndex(int [,] outArray, int X, int Y)
{
    if( X < 0 || Y < 0 || X > outArray.GetLength(0) || Y > outArray.GetLength(1))
    {
        Console.Write($"There is no such element in array");
    }
    else
    {
        Console.Write($"Your number in array {outArray[X,Y]}");
    }
}

Console.Write("Enter numbers of rows m: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter numbers of columns n: ");
int column = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, column, -100, 100);
PrintArray(array);
Console.Write("Enter X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
GetIndex(array, X1, Y1);

