/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
void findNum(int num, int[] array)
{
for (int i = 0; i < array.Length; i++)
{
  if (array[i] == num)
  {
    Console.WriteLine($"Число {num}, есть в заданном массиве");
    return;
  }
}
Console.WriteLine($"Числа {num}, нет в заданном массиве");
}
void printArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
  Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}.");
}

int[] array = newArray(10, -10, 10);
findNum(5, array);
printArray(array);
