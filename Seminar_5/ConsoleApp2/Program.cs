/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] newArray(int size, int min, int max)
{
int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] =new Random().Next(min, max + 1);
  }
return array;
}
int[] swap(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
   array[i] *= -1;
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


int[] array = newArray(4, -99, 99);
printArray(array);
swap(array);
printArray(array);

