void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    collection[i] = new Random().Next(0, 1000);
}

void PrintArray(int[] col)
{
    Console.Write("[");
    for(int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]}, ");
    }
    Console.Write("]");
}
Console.Write("Enter the array length: ");
int N = int.Parse(Console.ReadLine()!);
int [] array = new int[N];
Console.WriteLine("Your array: ");
FillArray(array);
PrintArray(array);