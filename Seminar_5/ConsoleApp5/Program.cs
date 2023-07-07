/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
int[] mult(int[] array)
{
int size = -1;
int multiply = -1;
int a = array.Length - 1;
  if (array.Length % 2 == 0)
  {
    size = array.Length / 2;
  }
  else
  {
    size = (array.Length / 2) + 1;
  }

  int[] resArray = new int[size];

  for (int i = 0; i < array.Length/2; i++)
  {
    multiply = array[i] * array[a];
    a--;
    resArray[i] = multiply;
  }

  if (array.Length % 2 > 0)
  {
    resArray[resArray.Length - 1] = array[array.Length / 2];
  }

return resArray;
}



int[] array = newArray(11, 0, 10);
printArray(array);
int[] array2 = mult(array);
printArray(array2);




