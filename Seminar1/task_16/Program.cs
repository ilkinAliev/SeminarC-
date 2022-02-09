// Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным

Console.Write("введите день недели - ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 5 & day < 8)
{
    Console.WriteLine(day + " день недели - выходной");
}
else if ( day > 0 & day <= 5)
{
    Console.WriteLine(day + " день недели - рабочий");
}
else
    Console.WriteLine("введите число от 1 до 7");