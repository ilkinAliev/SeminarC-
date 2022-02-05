// По заданному номеру дня недели вывести его название

Console.Write("введите день недели - ");
int n = int.Parse(Console.ReadLine());

string[] DayOfWeek = new string[7] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение" };
if (n < DayOfWeek.Length + 1)
{
    Console.WriteLine(DayOfWeek[n - 1]);
}
else
{
    Console.WriteLine("неправильно введен день недели");
}