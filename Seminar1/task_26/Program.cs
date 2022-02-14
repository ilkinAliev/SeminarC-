// Возведите число А в натуральную степень B используя цикл

Console.Write("введите число - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень возведения - ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine($"{A}^{B} = {result}");