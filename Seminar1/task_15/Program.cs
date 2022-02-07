// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

void Multiplies(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        Console.WriteLine("число кратно 7 и 23");
    else if (num % 7 == 0)
        Console.WriteLine("число кратно только 7");
    else if (num % 23 == 0)
        Console.WriteLine("число кратно только 23");
    else
        Console.WriteLine("число не кратно 7 и 23");
}   


Multiplies(number);    
