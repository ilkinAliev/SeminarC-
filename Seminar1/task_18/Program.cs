// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = true;

if (!(x | y) == !x & !y)
    Console.WriteLine("при х=true и y=true - утверждение истинно");
else
    Console.WriteLine("при х=true и y=true - утверждение не истинно");


bool x1 = true;
bool y1 = false;
if (!(x1 | y1) == !x1 & !y1)
    Console.WriteLine("при х=true и y=false - утверждение истинно");
else
    Console.WriteLine("при х=true и y=false - утверждение не истинно");

bool x2 = false;
bool y2 = false;
if (!(x2 | y2) == !x2 & !y2)
    Console.WriteLine("при х=false и y=false - утверждение истинно");
else
    Console.WriteLine("при х=false и y=false - утверждение не истинно");

bool x3 = false;
bool y3 = true;
if (!(x3 | y3) == !x3 & !y3)
    Console.WriteLine("при х=false и y=true - утверждение истинно");
else
    Console.WriteLine("при х=false и y=true - утверждение не истинно");