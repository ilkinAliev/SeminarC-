// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =Math.Round( new Random().NextDouble() * 1000, 2); // округляем вещественные числа до сотых
    }
}
void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[ i] + " "); 
    }
    Console.WriteLine("]");
}

double[] massive = new double[20];

FillArray(massive);
PrintArray(massive);

double max = 0;
double min = 1000;

foreach (double x in massive)
{
    if (x > max)
        max = x;
    else if (x < min)
        min = x;
}
Console.WriteLine($"max = {max}, min = {min}, max - min = {Math.Round(max - min, 2)}");