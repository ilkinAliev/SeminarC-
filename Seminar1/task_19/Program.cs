// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = new Random().Next(-50, 50);
Console.Write("x = " + x + ";");
int y = new Random().Next(-50, 50);
Console.WriteLine(" y = " + y);

if (x > 0 & y > 0)
    Console.WriteLine("точка находится в I четверти");
else if (x < 0 & y > 0)
    Console.WriteLine("точка находится в II четверти");
else if (x < 0 & y < 0)
    Console.WriteLine("точка находится в III четверти");
else if (x > 0 & y < 0)
    Console.WriteLine("точка находится в IV четверти");
else
    Console.WriteLine("невозможно определить четверть, точка лежит на 0 плоскости");