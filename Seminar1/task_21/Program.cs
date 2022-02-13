// Программа проверяет пятизначное число на палиндромом

Console.WriteLine("введите 5-значное число - ");
string numbers = Convert.ToString(Console.ReadLine());
char[] Polyndrom = new char[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    Polyndrom[i] = numbers[i];
}


if (Polyndrom[0] == Polyndrom[4] & Polyndrom[1] == Polyndrom[3])
    Console.WriteLine("число является полиндромом");
else
    Console.WriteLine("число не является полиндромом");