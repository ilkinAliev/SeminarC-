// Найти максимальное из трех чисел

int a = new Random().Next(1, 1001);
Console.Write("число a = " + a);

int b = new Random().Next(1, 1001);
Console.Write(", число b = " + b);

int c = new Random().Next(1, 1001);
Console.WriteLine(", число c = " + c);


if (a >= b && a >= c)
{
    Console.WriteLine("максимальное число = " + a);
}
else if (b >= a && b >= c)
{
    Console.WriteLine("максимальное число = " + b);
}
else
{
    Console.WriteLine("максимальное число = " + c);
}
