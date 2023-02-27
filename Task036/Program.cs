// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
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

void PossitionSum(int[] outArray)
{
    int negativeSum = 0;
    for(int i = 0; i < outArray.Length; i+=2)
    {
        negativeSum = negativeSum + outArray[i];
    }
    Console.Write($"Сумма элементов, стоящих на нечётных позициях: {negativeSum}");
}


Console.Write("Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize, 100, 999);
PrintArray(array);
Console.WriteLine();
PossitionSum(array);