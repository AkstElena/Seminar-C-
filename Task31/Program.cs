// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int [] points = new int[2];
Console.WriteLine("Ввод Х && У");

for (int i = 0; i < points.Length; i = i + 1)
points[i]= Convert.ToInt32(Console.ReadLine());

if (points [0]> 0 && points [1] > 0)
    Console.WriteLine("Это 1-ая четверть");
else if (points [0]< 0 && points [1] > 0)
    Console.WriteLine("Это 2-ая четверть");
else if (points [0]< 0 && points [1] < 0)
    Console.WriteLine("Это 3-ая четверть");
else if (points [0]> 0 && points [1] < 0)
    Console.WriteLine("Это 4-ая четверть");
else  Console.WriteLine("Х && У = 0");
