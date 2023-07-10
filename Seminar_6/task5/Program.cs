﻿/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
int[] generateArray(int length, int min, int max) 
{
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
  array[i] = new Random().Next(min, max + 1); 
}
return array;
}
void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"{array[i]} ");
}
}


int[] array = generateArray(10, 1, 100);

int[] copyArray = new int[array.Length];
for (int i = 0; i < copyArray.Length; i++)
{
  copyArray[i] = array[i];
}

printArray(array);
Console.WriteLine(" ");
printArray(copyArray);