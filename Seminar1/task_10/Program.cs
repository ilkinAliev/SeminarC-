// Показать вторую цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int digit3 = number % 100 / 10;

Console.WriteLine("вторая цифра введенного числа - " + digit3);