/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/
void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"{array[i]} ");
}
}
int[] binaryNum(int n)
{
if (n == 0)
{
  int[] array1 = new int[1];
  return array1;
}
int size = 0;
int i = 0;
int NArray = n;
while (n >= 1)
{
  n = n / 2;
  size++;
}
int[] array = new int[size];
while (NArray >= 1)
{
  
  if (NArray%2 == 0)
  {
    array[size - 1] = 0;
  }
  else
  {
    array[size - 1] = 1;
  }
  NArray = NArray / 2;
  i++;
  size--;
}
return array;
}


Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()); 


int [] array = binaryNum(n);

Console.WriteLine("");

printArray(array);











