/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int sum( int number)
{
int result = 0;
for (int i = number; i > 0; i--)
{
  result = result + i;
}
return result;
}

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int answer = sum( numb );
Console.WriteLine($"Ответ: {answer}");
