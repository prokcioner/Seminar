/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

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
void swapArray(int[] array)
{
  int temp = -1;
  int a = array.Length - 1;
  for (int i = 0; i < array.Length / 2; i++)
  {
    temp = array[i];
    array[i] = array[a];
    array[a] = temp;
    a--;
  }
}


int[] array = generateArray(7, 1, 5);
printArray(array);
Console.WriteLine("");
swapArray(array);
printArray(array);

