// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

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

void FindIndex(int[] outArray, int minDigit, int maxDigit)
{
    int count = 0;
    for(int i = 0; i < outArray.Length; i++)
    if(outArray[i] >= minDigit & outArray[i] <= maxDigit) 
    {
        count = count + 1;
    }
    Console.Write($"На отрезке от [{minDigit}, {maxDigit}] в вашем массиве лежит {count} чисел");
}

Console.Write($"Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize, -1000, 1000);
PrintArray(array);
Console.WriteLine();
FindIndex(array, 10, 99);
