// Задача 50: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования

int Promt(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int[] GetArray(int number)
{
  int[] array = new int[number];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 100);
  }
  return array;
}

int [] ArrayCopy (int [] array)
{
    int [] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int number = Promt("Введите длину массива: ");
int[] array = GetArray(number);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Копия массива:[{String.Join(", ", ArrayCopy(array))}]");
