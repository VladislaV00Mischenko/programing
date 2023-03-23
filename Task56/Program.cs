// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
//  1 строка
int[,] matrix = CreateMatrixRndInt(9, 5, 0, 100);
PrintMatrix(matrix);
int[] array = SumRowsMatrix(matrix);
int minElem = MinRow(array);
Console.WriteLine($"Найменьшая сумма в {minElem} строке");

int MinRow(int[] arr)
{
    int min = arr[0],index = 0;
     for (int i = 1; i < arr.Length; i++)
    {
        if(min > arr[i]) 
        {
        min = arr[i];
        index = i;
        }
    }
    return index + 1;
}

int[] SumRowsMatrix(int[,] matr)
{
    int[] array =new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        array[i] = sum;
    }
    return array;
}

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

void PrintMatrix(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          
         Console.Write($" {matr[i, j], 4}");
        }
         Console.WriteLine("|");
    }
    

}

