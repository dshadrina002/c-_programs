// Console.Write("Enter X: ");
// int X = int.Parse(Console.ReadLine());
// Console.Write("Enter Y: ");
// int Y = int.Parse(Console.ReadLine());
// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("I quarter");
// }
// if (X > 0 && Y < 0)
// {
//     Console.WriteLine("II quarter");
// }
// if (X < 0 && Y < 0)
// {
//     Console.WriteLine("III quarter");
// }
// if (X < 0 && Y > 0)
// {
//     Console.WriteLine("IV quarter");
// }

// Console.Write("Enter number of Quarter: ");
// int Q = int.Parse(Console.ReadLine());
// if(Q == 1)
// {
//     Console.WriteLine("X > 0, Y > 0");
// }
// if (Q == 2)
// {
//     Console.WriteLine("X > 0 && Y < 0");
// }
// if (Q == 3)
// {
//     Console.WriteLine("X < 0 && Y < 0");
// }
// if (Q == 4)
// {
//     Console.WriteLine("X < 0 && Y > 0");
// }
// else
// {
//     Console.WriteLine("Incorrect. Enter the number from 1 to 4");
// }

Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine());
for (int i=1; i <= N; i++)
{
    Console.Write(Math.Pow(i,2) + ", ");
}