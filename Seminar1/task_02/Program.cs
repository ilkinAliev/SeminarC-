// Даны два числа. Показать большее и меньшее число

int n = new Random().Next(1, 1001);
Console.Write(" первое число = " + n);

int p = new Random().Next(1, 1001);
Console.WriteLine(" второе число = " + p);

if( n > p)
{
    Console.WriteLine(n + " > " + p);
}
else if(n < p) 
{
    Console.WriteLine(n + " < " + p);
}
else
{
    Console.WriteLine( n + " = " + p);
}