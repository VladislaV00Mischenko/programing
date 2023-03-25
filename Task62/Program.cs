// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
 
 int[,] matrix = new int[4,4];

FillMatrixSpiral(matrix);
PrintMatrix(matrix);



 void FillMatrixSpiral(int[,] matr)
 {
    int num = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[0,i] = num++;
    }
    for (int i = 1; i < matr.GetLength(1); i++)
    {
        matr[i,matr.GetLength(0)-1] = num++;
    }
    for (int i = matr.GetLength(1) -2; i >= 0; i--)
    {
        matr[matr.GetLength(0)-1, i] = num++;
    }
    for (int i = matr.GetLength(1) - 2;i > 0; i--)
    {
        matr[i,0] = num++;
    }
    for (int i = 1; i < matr.GetLength(0)-1; i++)
    {
        matr[1,i] = num++;
    }
    for (int i = 2; i < matr.GetLength(1)-1; i++)
    {
        matr[i,matr.GetLength(0)-2] = num++;
    }
    for (int i = matr.GetLength(1) -3; i > 0; i--)
    {
        matr[matr.GetLength(0)-2, i] = num++;
    }
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