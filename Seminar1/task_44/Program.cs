// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write("введите значение k1 - ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("введите значение b1 - ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("введите значение k2 - ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("введите значение b2 - ");
int b2 = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;

if (k1 == k2)
    Console.WriteLine("функции параллельны и не пересекаются");
else
{
    x = (b2 -b1) / (k1 -k2);
    y = k1 * x + b1;
    Console.WriteLine($"точка пересечения функций имеет координаты x={x}, y={y}");
} 

