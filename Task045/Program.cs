// Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

int[] FullArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int [] copyArr (int [] arr)
{
    int [] copArr  = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copArr[i] = arr [i];
    }
    return copArr;
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

int [] firstArr = (FullArray(5, 1, 11));
PrintArray(firstArr);
int [] secArr = copyArr(firstArr);
PrintArray(secArr);
