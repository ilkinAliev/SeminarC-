// Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("введите количество чисел - ");
int n = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"введите число №{i+1} ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine("количество чисел больше 0 = " + count);