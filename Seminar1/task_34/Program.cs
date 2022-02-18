// Написать программу замену элементов массива на противоположные
// 2 варианта: противоположные по значению(AntiArray) и противоположные по месту в массиве(ChangePlace)

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 20);
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


void AntiArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] Massive = new int[11];
FillArray(Massive);
PrintArray(Massive);
AntiArray(Massive);
PrintArray(Massive);

void ChangePlace(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i]  = arr[arr.Length-1-i];
        arr [arr.Length-1-i] = temp;
    }
}

ChangePlace(Massive);
PrintArray(Massive);