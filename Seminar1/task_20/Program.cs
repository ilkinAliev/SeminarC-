// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти (1,2,3,4) - ");
int range = Convert.ToInt32(Console.ReadLine());

if(range == 1) Console.WriteLine("в I четверти  значения х,y будут: x>0, y>0");
else if (range == 2) Console.WriteLine("во II четверти  значения х,y будут: x<0, y>0");
else if (range == 3) Console.WriteLine("в III четверти  значения х,y будут: x<0, y<0");
else if (range == 4) Console.WriteLine("в IV четверти  значения х,y будут: x>0, y<0");
else Console.WriteLine("введите корректный номер координатной четверти");