// В двумерном массиве n×k заменить четные элементы на противоположные

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
        mass[i,j] = new Random().Next(0,11);
        Console.Write(mass[i,j] + " ");
    }
}

Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
     Console.WriteLine();
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i,j] % 2 == 0)
        {
            Console.Write(mass[i,j] * -1 + "   ");
        }
        else 
        {
            Console.Write($"{mass[i,j]}" + "   ");
        }    
    }
}