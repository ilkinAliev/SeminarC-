// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("введите параметр m - ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите параметр n - ");
int n = int.Parse(Console.ReadLine());

double[,] mass = new double[m, n];


for (int i = 0; i < mass.GetLength(0); i++)
{
     Console.WriteLine();
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = Math.Round((new Random().NextDouble() * 100) , 2);
        Console.Write(mass[i,j] + "\t");
    }
}