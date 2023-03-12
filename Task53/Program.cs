// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int [] GetArray()
{
  int [] array = new int[12];
  for (int i =0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 1000);
  }
return array;
}

int [] array = GetArray();
Console.WriteLine($"[{String.Join(" ", array)}]");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


bool FindNumber (int [] array, int number)
{
for (int i = 0; i<array.Length; i++)
{
  if (array[i] == number)
    return true;
  
}
return false;
}

if (FindNumber(array, number)) 
{
  Console.WriteLine($"Число {number} присутствует в заданном массиве");
}
else Console.WriteLine($"Число {number} отсутствует в заданном массиве");
