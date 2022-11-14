﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int [] Fibon (int num)
{
    int [] arr = new int [num];
    arr[1] = 1;
  for (int i = 2; i < num; i++)
  {
    arr[i] = arr[i-2]+arr[i-1];
  }
 return arr;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
Console.WriteLine("Ведите нужное число последовательности:");
int n = Convert.ToInt32(Console.ReadLine());

int [] fibarr = Fibon(n);
PrintArray(fibarr);