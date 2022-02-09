// Найти третью цифру числа или сообщить, что её нет

Console.Write("введите число ");
int  number = Convert.ToInt32(Console.ReadLine());

if(number / 100 > 0)
{
    int thirdDigit = number / 100 % 10;
    Console.WriteLine("третья цифра введенного числа = " + thirdDigit);
}
else
    Console.WriteLine("у введенного числа нет третьей цифры");
    