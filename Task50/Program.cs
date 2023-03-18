
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
int[,] matrix = CreateMatrixRndInt(5, 5, -10, 10);
Console.Write("Введите индекс строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int j = Convert.ToInt32(Console.ReadLine());


if (i < 0 && j < 0)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент массива = {matrix[i, j]}");
    }
    else Console.WriteLine("Такого элемента в массиве нет");
}
else Console.WriteLine("Такого элемента в массиве нет");



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}