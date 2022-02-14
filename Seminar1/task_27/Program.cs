// Определить количество цифр в числе

Console.Write("введите число - ");
int A = Convert.ToInt32(Console.ReadLine());

//избавляемся от возможного минуса
int B = 0;
if (A < 0) B = A * -1;
else B = A;

String strB = B.ToString();

Console.WriteLine(strB.Length);

