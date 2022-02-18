// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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

int a = new Random().Next(7, 21);
int[] Array = new int[a];
FillArray(Array);
PrintArray(Array);

if (a % 2 == 0)
{
    for (int i = 0; i < a / 2; i++)
    {
        Console.WriteLine($"{Array[i]} * {Array[a - i - 1]} = {Array[i] * Array[a - i - 1]}");
    }
}
else
{
    for (int i = 0; i < a / 2; i++)
    {
        Console.WriteLine($"{Array[i]} * {Array[a - i - 1]} = {Array[i] * Array[a - i - 1]}");
    }
    Console.WriteLine($"непарный член массива возводится в квадрат: {Array[a / 2]} * {Array[a / 2]} = {Array[a/2]*Array[a/2]}");
}