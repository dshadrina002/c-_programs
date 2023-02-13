void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    collection[i] = new Random().Next(1, 100);
}

void PrintArray(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    Console.Write(col[i] + " ");
}

void IndexOf(int[] collection, int find)
{
    int check = -1;
    for(int i = 0; i < collection.Length; i++)
    if(collection[i] == find)
    {
        Console.WriteLine("Your number: " + i);
        check = i;
    }
    if(check == -1)
    Console.WriteLine("Your number is not in array");
}

Console.Write("Enter the array length: ");
int count = int.Parse(Console.ReadLine()!);
int[] array = new int[count];
Console.WriteLine("Your array: ");
FillArray(array);
PrintArray(array);

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine()!);
IndexOf(array, a);

// Console.Write("Enter the array length: ");
// int count1 = int.Parse(Console.ReadLine()!);
// int[] array1 = new int[count1];
// Console.WriteLine("Your array: ");
// FillArray(array1);
// PrintArray(array1);

// Console.Write("Enter number: ");
// int b = int.Parse(Console.ReadLine()!);
// IndexOf(array1, b);

// Console.Write("Enter index: ");
// int i = int.Parse(Console.ReadLine()!);
// Console.Write(array[i]);
