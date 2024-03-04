 // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

 int x=0;
 int y=0;
 if (x > 0 && y > 0){
Console.Write("1");
 }
else if (x < 0 && y > 0){
Console.WriteLine("2");
}
else if (x < 0 && y < 0){
Console.WriteLine("3");
}
else if (x > 0 && y < 0){
Console.WriteLine("4");
}
else
Console.WriteLine("Точка в центре");