// Определить, присутствует ли в заданном массиве, некоторое число


void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 11);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

Console.Write("введите число от 0 до 10 для проверки на наличие в массиве - ");
int number = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[20];
FillArray(mass);
PrintArray(mass);

Console.WriteLine();

int count = 0;
foreach (int x in mass)
{
    if (x == number)
    {
        Console.WriteLine($"число {number} присутствует в массиве");
        count++; 
        break;       
    }
}

if(count == 0) Console.WriteLine($"число {number} не присутствует в массиве");