
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);
int numSearch = NumSearch(array);
Console.WriteLine($"Количество двухзначных чисел в массиве = {numSearch}");

int NumSearch(int[] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i] < 100 ) count += 1;
    }
    return count;
}


void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 200);
    }

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