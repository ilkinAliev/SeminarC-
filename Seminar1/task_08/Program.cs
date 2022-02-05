// Показать четные числа от 1 до N

Console.Write("введите число - ");
int n = Convert.ToInt32(Console.ReadLine());

int k = 2;
while (k < n)
{
    Console.Write(k + "  ");
    k = k + 2;
}