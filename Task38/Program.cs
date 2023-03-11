//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(15, 0, 200);
PrintArrayDouble(array);
double minElementArray = MinElementArray(array);
double maxElementArray = MaxElementArray(array);
double diffElement = DiffElement( maxElementArray, minElementArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diffElement}");

double DiffElement(double max, double min)
{
    double diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}

double MinElementArray(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}


double MaxElementArray(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}


void PrintArrayDouble(double[] arr)
{
Console.Write("[");
for(int i = 0; i < arr.Length; i++)
{
    if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
}
Console.WriteLine("]");

}