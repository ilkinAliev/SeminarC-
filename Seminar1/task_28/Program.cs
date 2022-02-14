// Подсчитать сумму цифр в числе

Console.Write("введите число - ");
int A = Convert.ToInt32(Console.ReadLine());

if (A < 0) A = A * -1;

int sum = 0;
while(A > 0)
{
    sum = sum + (A % 10);
    
    A = A /10;
}

Console.WriteLine($"сумма цифр в числе = {sum}");