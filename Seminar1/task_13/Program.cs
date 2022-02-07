// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Multiples(int a, int b)
{
    int max = 0;
    int min = 0;
    if (a >= b)
    {
        max = a;
        min = b;
    }
    else
    {
        max = b;
        min = a;
    }
    int surplus = max % min;
    if (surplus == 0)
    {
        Console.WriteLine($"число {max} кратно числу {min}");
    }
    else
    {
        Console.WriteLine($"число {max} не кратно числу {min}, остаток {surplus}"); 
    }
}

Multiples(num1, num2);
