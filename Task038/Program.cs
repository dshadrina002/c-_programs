// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray (int[] inArray)
{
    Console.Write($"Your array: [ ");
    for(int i=0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.Write($"]");
}

void GetMinMax(int[] outArray)
{
    int max = 0;
    int min = 0;
    for(int i=0; i<outArray.Length;i++)
    {
        if(outArray[i]>max) max = outArray[i];
        else if(outArray[i]< min) min = outArray[i];
    }
    int dif = max - min;
    Console.Write($"Min value in array = {min}. Max value in array = {max}");
    Console.WriteLine();
    Console.Write($"Difference between max and min value = {dif}");
}

Console.Write("Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize, -99, 99);
PrintArray(array);
Console.WriteLine();
GetMinMax(array);
