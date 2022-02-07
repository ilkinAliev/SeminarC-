// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(11, 99);
Console.WriteLine("дано число " + number);

int DigitsCompare(int num)
{
    int a = num % 10;
    int b = num / 10;

    if (a > b)
        return a;
    else
        return b;
}

Console.WriteLine($"наибольшая цифра числа - {DigitsCompare(number)}");