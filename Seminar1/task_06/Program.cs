﻿// Выяснить является ли число чётным

Console.Write("введите число ");
int n = Convert.ToInt32(Console.ReadLine());

if( n % 2 == 0)
{
    Console.WriteLine("число " + n + " - четное");
}
else
{
    Console.WriteLine("число " + n + " - нечетное");  
}