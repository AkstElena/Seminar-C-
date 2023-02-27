// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
  Console.WriteLine(number1 + " кратно " + number2);
else
{
   Console.WriteLine(number1 + " некратно " + number2);
   Console.WriteLine("Остаток от деления: " + (number1 % number2));
}

// string result = number1 % number2 == 0? "Второе число кратно первому":$"Второе число не кратно первому. Остаток от деления = {number1 % number2}";