// Показать числа Фибоначчи
int[] f = new int[20]; // до 20 числа покажем
f[0] = 1;
f[1] = 1;
Console.Write(f[0] + " " + f[1] + " ");
for (int i = 2; i < f.Length; i++)
{
    f[i] = f[i - 2] + f[i - 1];
    Console.Write(f[i] + " ");
}