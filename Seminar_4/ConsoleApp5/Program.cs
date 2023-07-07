/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/


int[] newArray(int num, int minValue, int maxValue)
{
int[] array = new int[num];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
return array;
}

Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

int[] array = newArray(length, min, max);

for (int i = 0; i < array.Length ; i++)
{
  Console.Write($"{array[i]}");
}
