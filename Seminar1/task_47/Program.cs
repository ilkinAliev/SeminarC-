// Написать программу копирования массива

int[] a = { 1, 2, 43, 4, 5, 7, 78 };
int[] b = new int[a.Length];


void CopyMass(int[] arr1, int[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr2[i] = arr1[i];
    }
}

CopyMass(a, b);

for (int i = 0; i < b.Length; i++)
{
    Console.Write(b[i] + " ");
}
