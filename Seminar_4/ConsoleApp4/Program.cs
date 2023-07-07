/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

int factorial(int number)
{
int mult = 1;
for (int i = number; i > 0; i--)
{
  mult *= i;
}
return mult;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
  Console.WriteLine("Введите положительное число!");
  Environment.Exit(0);
}
int result = factorial(num);
Console.WriteLine($"Ответ: {result}");