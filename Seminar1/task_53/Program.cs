// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
        mass[i, j] = new Random().Next(0, 11);
        Console.Write(mass[i, j] + "\t");
    }
}

Console.WriteLine();
Console.WriteLine("введите число - ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine();
int count = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] == number)
        {
            Console.WriteLine($"число {number} находится на позиции [{i};{j}]");
            count = count + 1;
        }
    }
}

if (count == 0) Console.WriteLine($"число {number} не встречается в массиве");
else Console.WriteLine($"число {number}  встречается в массиве {count} раз");
