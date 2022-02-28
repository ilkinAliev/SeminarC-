// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Write("введите количество строк в масиве - ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите количество столбцов в массиве - ");
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

for (int j = 0; j < mass.GetLength(1); j++)
{
    Console.WriteLine();
    double sum = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum = sum + (double) mass[i,j];
    }
    Console.WriteLine($"арифметическая сумма в столбце №{j} = {Math.Round((sum / m), 2)}");
}