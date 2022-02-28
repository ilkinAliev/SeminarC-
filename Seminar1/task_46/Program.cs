// Написать программу масштабирования фигуры

string s = "Когда уже это закончится? - спросил юный падаван Мастера";
char[] separators = new char[] {' ', '?', '-'};
string[] sub = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < s.Length; i++)
{
    Console.WriteLine(sub[i]);
}