// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
Console.Write("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

Console.WriteLine("Введите числа");
ArrayFill(number);
PrintArray(array);
int positiveNum = CheckPositivNum(array);
Console.WriteLine($"Количество положительных чисел = {positiveNum}");

int CheckPositivNum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0 ) result ++;
    }
    return result;
}
void ArrayFill(int num)
{
    for (int i = 0; i < num; i++)
    {

        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    
}



void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}
