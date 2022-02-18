// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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

int even = 0;
int uneven = 0;
foreach (int item in massive)
{
    if (item % 2 == 0)
        even++;
    else
        uneven++;
    
}
Console.WriteLine($"четных чисел в массиве - {even}, нечетных чисел - {uneven}");