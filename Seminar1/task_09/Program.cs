// написать функцию, которая будет показать последнюю цифру трёхзначного числа

int LastDigit(int number)
{
    int last = number % 10;
        return last;
}

int num = new Random().Next(100, 1000);
int lastdigit = LastDigit(num);


Console.WriteLine($"последней цифрой трехзначного числа {num} является цифра {lastdigit}");

