// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    Console.Write($"Your array: [ ");
    for(int i = 0; i<inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.Write("]");   
}

void GetCount(int[] outArray)
{
    int evenCount = 0;
    for(int i=0; i<outArray.Length; i++)
    {
        if(outArray[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    Console.Write($"Количество чётных чисел в массиве: {evenCount}");  
}    

Console.Write($"Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize, 100, 999);
PrintArray(array);
Console.WriteLine();
GetCount(array);