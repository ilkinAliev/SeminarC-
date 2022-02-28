// Выяснить являются ли три числа сторонами треугольника

Random rand = new Random();
int a = rand.Next(1, 50);
int b = rand.Next(1, 50);
int c = rand.Next(1, 50);
Console.WriteLine(a + "  " + b + "  " + c);

if ((a + b > c) && (a + c > b) && (b + c > a))
{
    Console.WriteLine("числа являются сторонами треугольника");
}
else
    Console.WriteLine("числа  не являются сторонами треугольника");