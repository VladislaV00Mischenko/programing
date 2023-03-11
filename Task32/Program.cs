﻿void PrintArray(int[] arr)
{
Console.Write("[");
for(int i = 0; i < arr.Length; i++)
{
    if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
}
Console.WriteLine("]");
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


void EditArray(int[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        arrayValue[i] *= -1;
    }
}

int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);
EditArray(array);
PrintArray(array);

