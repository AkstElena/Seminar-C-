// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
string hello = "hello";
Console.WriteLine("Ваш результат: ");
Console.WriteLine(result);

Console.WriteLine("Ваш результат: " + result);

Console.WriteLine("Ваш {1} результат: {0}", result, hello);

Console.WriteLine($"Ваш результат: {number * number}");