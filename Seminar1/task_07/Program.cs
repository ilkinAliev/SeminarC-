// Показать числа от -N до N

Console.Write("введите число N - ");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 0)
{
    int a = - N;
    while (a <= N)
    {
        Console.Write(a + " ");
        a++;
    }
}
else
{
    int a = N;
    while (a <= -N)
    {
        Console.Write(a + " ");
        a++;
    }  
}