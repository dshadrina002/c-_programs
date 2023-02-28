// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

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
    Console.Write($"Your array [ ");
    for(int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.Write($"]");
}

void FindIndex(int[] outArray, int digit)
{
    int check = -1;
    for(int i = 0; i < outArray.Length; i++)
    if(outArray[i] == digit) 
    {
        Console.WriteLine($"Your digit is in array. Index {i}");
        check = i;
    }
    if(check == -1)
    Console.Write($"Your digit is NOT in array");
}

Console.Write($"Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize, -9, 9);
PrintArray(array);
Console.WriteLine();
Console.Write($"Enter digit: ");
int dig = int.Parse(Console.ReadLine()!);
FindIndex(array, dig);


    