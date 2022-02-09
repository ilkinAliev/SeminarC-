// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("какое по порядку число нужно удалить? ");
int sequence = Convert.ToInt32(Console.ReadLine());

int DeleteSequence(int integer, int seq)
{
    int addballance = integer % Convert.ToInt32(Math.Pow(10, seq -1));
    int newnumber = integer / Convert.ToInt32(Math.Pow(10, seq)) * Convert.ToInt32(Math.Pow(10, seq-1)) + addballance;
    return newnumber;
}

Console.Write("новое число " + DeleteSequence(number, sequence));