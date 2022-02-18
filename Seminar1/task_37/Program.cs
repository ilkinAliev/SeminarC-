// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1001);
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

int[] Array = new int[123];
int count = 0;
FillArray(Array);
foreach (int x in Array)
{
    if (9 < x & x < 100)
    {
        count++;
    }
}
PrintArray(Array);
Console.WriteLine("в данном масиве количество чисел из отрезка [10,99] = " + count);