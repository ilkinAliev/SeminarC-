//По двум заданным числам проверять является ли одно квадратом другого

Console.Write("введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

if (max == min * min)
    Console.Write($"{max} является квадратом {min}");
else
    Console.Write("одно число не является квадратом другого");