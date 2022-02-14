// Найти кубы чисел от 1 до N

Console.Write("введите натуральное число - ");
int N = int.Parse(Console.ReadLine());
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
    }
}
else Console.WriteLine("попробуйте снова ввести натуральное число (целое и положительное)");
