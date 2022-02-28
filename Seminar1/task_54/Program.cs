//В матрице чисел найти сумму элементов главной диагонали

Console.Write("введите параметр n - ");
int n = int.Parse(Console.ReadLine());
Console.Write("введите параметр k - ");
int k = int.Parse(Console.ReadLine());

int[,] mass = new int[n, k];


for (int i = 0; i < mass.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 11);
        Console.Write(mass[i, j] + "\t");
    }
}
int sum = 0;
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = sum + mass[i, j];
        }
    }    
}
Console.WriteLine("сумма элементов главной диагонали = " + sum);