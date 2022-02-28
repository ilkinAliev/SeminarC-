// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());
int k;
string result = string.Empty;
while (num > 0)
{
    k = num % 2;
    result = k + result;
    num = num / 2;
}

Console.WriteLine("вывод - " + result);