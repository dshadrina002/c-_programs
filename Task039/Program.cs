// задача 39. Переворот массива

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

void ReverseArray(int[] outArray) // переставляем с пправа на лево
{
    for(int i = 0; i<outArray.Length /2 ; i++)
    {
        int k = outArray[i];
        outArray[i] = outArray[outArray.Length-1-i];
        outArray[outArray.Length-1-i] = k;
    }
}

int[] ReverseArray2(int[] collection)
{
    int[] result = new int[collection.Length];
    for(int i = 0; i < collection.Length; i++)
    {
        result[i] = collection[collection.Length - 1 - i];
    }
    return result;
}

int[] array = GetArray(10, 0, 10);
PrintArray(array);
int[] reverseArray = ReverseArray2(array);
Console.WriteLine();
PrintArray(reverseArray);
//Console.WriteLine(string.Join(" ", array)); тоже вывод массива