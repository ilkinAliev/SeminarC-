// Написать программу вычисления произведения чисел от 1 до N

Console.Write("введите натуральное число - ");
int A = Convert.ToInt32(Console.ReadLine());

if(A < 1)
     Console.Write("введите натуральное число!"); 
else 
    Console.WriteLine($"произведение чисел от 1 до {A} = {Fractal(A)}");

int Fractal(int arg)
{
    int result = 1;
    for (int i = 2; i <= arg; i++)
    {
        result = result * i;
    }
    return result;  
}

