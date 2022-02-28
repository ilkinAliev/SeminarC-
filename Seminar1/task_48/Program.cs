// Показать двумерный массив размером m×n заполненный целыми числами

Console.Write("введите параметр m - ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите параметр n - ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];


for (int i = 0; i < mass.GetLength(0); i++)
{
     Console.WriteLine();
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(0,11);
        Console.Write(mass[i,j] + " ");
    }
}