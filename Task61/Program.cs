// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (
// последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int [] GenerateArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 10);
  }
  return array;
}

int [] ReversArray(int[] array)
{
   for (int i = 0; i < array.Length/2; i++)
  {
    int tmp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = tmp;
  }
  return array;
}


int lenght = Promt("Введите длину массива: ");
int[] newArray = new int[lenght];
Console.WriteLine($"[{String.Join(", ", GenerateArray(newArray))}]");
Console.WriteLine($"Перевернутый массив: [{String.Join(", ", ReversArray(newArray))}]");