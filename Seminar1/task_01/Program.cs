// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("введите первое число n = ");
int n = int.Parse(Console.ReadLine());

Console.Write("введите второе число p = ");
int p = int.Parse(Console.ReadLine());

if(n == p*p)
{
    Console.Write("число " + n);
    Console.WriteLine(" квадрат числа " + p);
    Console.WriteLine(n + " = " +  p + " * " +  p  );
  
}
else if(p == n*n)
{
        Console.Write("число " + p);
    Console.WriteLine(" квадрат числа " + n);
    Console.WriteLine(p + " = " +  n + " * " +  n  );
}
else
{
    Console.Write( n + " и " + p + " не являются квадратами друг друга");
   
}


