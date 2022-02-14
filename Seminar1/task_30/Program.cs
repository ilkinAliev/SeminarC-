// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("введите число - ");
int A = Convert.ToInt32(Console.ReadLine());

if(A > 0)
{
    int cube = 0;
    for (int x = 2; x < A; x+=2)
    {
        cube = x * x * x;
        Console.WriteLine($"{x}^{3}={cube}");
    }
}    
else
{
    int cube = 0;
    for (int x = -2; x > A; x-=2)
   {
        cube = x * x * x;
        Console.WriteLine($"{x}^{3}={cube}");
   } 
}