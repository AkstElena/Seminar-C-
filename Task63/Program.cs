// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int number = Promt("Введете десятичное число:");

string TenToTwo(int number)
{
  string firstResult = " ";
  while (number > 0)
  {
    string result = Convert.ToString(number % 2);
    result = result + firstResult;
    firstResult = result;
    number = number / 2;
  }
  return firstResult;
}

Console.Write($"В двоичном выражении: {TenToTwo(number)}");
