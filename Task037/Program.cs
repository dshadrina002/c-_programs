// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] Product(int[] outArray)
{
    int[] prod = new int[outArray.Length / 2];
    for(int i = 0; i < outArray.Length / 2; i++)
    {
        prod[i] = outArray[i] * outArray[outArray.Length-1-i];
    }
    return prod;
}

Console.Write($"Enter array length: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arraySize, 1, 10);
PrintArray(array);
Console.WriteLine();
int[] res = Product(array);
PrintArray(res);

