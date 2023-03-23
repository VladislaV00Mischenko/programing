// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 5);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 5);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] multiplaceMatrix = MultiplaceMatrix(matrix1, matrix2);
PrintMatrix(multiplaceMatrix);
int[,] MultiplaceMatrix(int[,] matr1,int[,] matr2)
{
    int[,] newMatrix = new int[matr1.GetLength(0),matr2.GetLength(1)];
    
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            
            for(int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[j, k] * matr2[k, j];
            }
            newMatrix[i, j] = sum;
        }
       
    }
    return newMatrix;
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
