// Найти расстояние между точками в пространстве 2D/3D
Console.Write("введите координату х1 - ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("введите координату у1 - ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("введите координату z1 (если нет - введите 0) - ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("введите координату х2 - ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("введите координату у2 - ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("введите координату z2 (если нет - введите 0) -");
double z2 = Convert.ToDouble(Console.ReadLine());

double[] cor1 = {x1, y1, z1};
double[] cor2 = {x2, y2, z2};

double Distance(double[] arr1, double[] arr2)
{
    double result = Math.Sqrt(Math.Pow(arr1[0]- arr2[0], 2) + Math.Pow(arr1[1] - arr2[1], 2) + Math.Pow(arr1[2] - arr2[2], 2));
    return result;
}
Console.Write($"расстояние между двумя точками равно = {Distance(cor1, cor2)}");