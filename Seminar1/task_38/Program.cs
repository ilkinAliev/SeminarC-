// Найти сумму чисел одномерного массива стоящих на нечетной позиции (по индексу)

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("]");
}

int[] massive = new int[20];

FillArray(massive);
PrintArray(massive);

int UnevensSum = 0;
for (int i = 1; i < massive.Length; i+=2)
{
    UnevensSum = UnevensSum + massive[i];
}
Console.WriteLine("сумма чисел нечетных индексов массива = " + UnevensSum);