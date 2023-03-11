//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = CreateArrayRndInt(12, 100, 999);
PrintArray(array);
EvenNumPrint(array);

void EvenNumPrint(int[] array)
{
    int evenNum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) evenNum += 1;
    }
    Console.WriteLine($"Количество чётных чисел в массиве = {evenNum} ");
}

void PrintArray(int[] arr)
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
