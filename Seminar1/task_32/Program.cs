// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] A = new int[8];

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write( arr[i] + " ");
    }
    Console.Write("]");
}



FillArray(A);
PrintArray(A);