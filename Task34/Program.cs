//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве

int [] pointA = new int [2];
int [] pointB = new int [2];


Console.WriteLine("Введите х и у для точки А");
for (int i = 0; i < pointA.Length; i = i + 1)
pointA[i]= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите х и у для точки В");
for (int i = 0; i < pointB.Length; i = i + 1)
pointB[i]= Convert.ToInt32(Console.ReadLine());

// double result = (((pointA[0]-pointB[0])^2 + (pointA[1]-pointB[1])^2))^(1/2);
//Console.WriteLine("Расстояние между точкой А и В = " + result);

double result = Math.Sqrt(Math.Pow(pointA[0]-pointB[0], 2) + Math.Pow(pointA[1]-pointB[1], 2));
Console.WriteLine("Расстояние между точкой А и В = " + Math.Round(result, 2));

