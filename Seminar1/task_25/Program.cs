// Найти сумму чисел от 1 до А

Console.Write("введите натуральное число - ");
int A = Convert.ToInt32(Console.ReadLine());

if (A > 1)
    Console.WriteLine($"сумма чисел от 1 до {A} = {(A + 1) * A / 2}");