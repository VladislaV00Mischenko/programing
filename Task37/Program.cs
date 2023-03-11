Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);
int[] newArray = Multiple(array);
PrintArray(newArray);

int[] Multiple(int[] arr)
{   
    int size = arr.Length / 2;
    if(arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];
    
    for(int i = 0;i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length -i - 1]; 
    }
    if(arr.Length % 2 != 0)
    newArr[size -1] = arr[arr.Length / 2];
    return newArr;
}

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 20);
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
