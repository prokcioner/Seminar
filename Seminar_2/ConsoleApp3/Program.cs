/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
 Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/

Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int b = int.Parse(Console.ReadLine());

int div = a%b;

if (div == 0)
{
  Console.WriteLine($"Число {a} кратно {b}");
}
else
{
  Console.WriteLine($"Число {a} не кратно {b}, остаток равен {div}");
}
