/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"{array[i]} ");
}
}
int[] generateArray(int length, int min, int max) 
{
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
  array[i] = new Random().Next(min, max + 1); 
}
return array;
}

int positiveNumber(int[] array)
{
int positiveSum = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0)
  {
  positiveSum += array[i];
  }
}
return positiveSum;
}

int negativeNumber(int[] array)
{
int negSum = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] < 0)
  {
  negSum += array[i];
  }
}
return negSum;
}


int[] array = generateArray(12, -9, 9);
printArray(array);

Console.WriteLine("");
Console.WriteLine($"Сумма положительных чисел равна {positiveNumber(array)}, а сумма отрицательных чисел {negativeNumber(array)}");




