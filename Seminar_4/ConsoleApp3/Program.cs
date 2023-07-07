/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int division(int num)
{
  int result = num;
  int i = 0;
  while (result > 0)
  {
    result /= 10;
    i++;
  }
  return i;
}

Console.Write("Введите значение: ");
int number = int.Parse(Console.ReadLine());
int answer = division(number);
Console.WriteLine($"Ответ: {answer}");




