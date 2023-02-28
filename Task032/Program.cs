// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    Console.Write($"Your array: [ ");
    for(int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.Write($"]");
}

void ReplaceIndex(int[] outArray)
{
    for(int i = 0; i < outArray.Length; i++)
    {
        outArray[i] *=-1;
    }
}

Console.Write($"Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize,-100,100);
PrintArray(array);
ReplaceIndex(array);
Console.WriteLine();
PrintArray(array);