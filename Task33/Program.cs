Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);
Console.Write("Введите число которое будем искать в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(ArraySearch(array, num) ? "Да" : "Нет");


bool ArraySearch(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
        
    }
    return false;
} 

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 10);
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
