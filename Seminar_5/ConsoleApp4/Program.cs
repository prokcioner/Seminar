/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int[] newArray(int size, int min, int max) 
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
  array[i] = new Random().Next(min, max);
}
return array;
}
void printArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
  Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}.");
}
int findNum(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 99 && array[i] > 10)
    {
      count++;
    }
  }
  return count;
}


int[] array = newArray(123, 0, 123);

Console.WriteLine($"В отрезке (10, 99) лежит {findNum(array)} чисел.");