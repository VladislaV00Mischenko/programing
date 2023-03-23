int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
SwapRowsAndColumns(matrix);
Console.WriteLine();
PrintMatrix(matrix);

void SwapRowsAndColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            int elem = matr[i, j];
            matr[i, j] = matr[j,i];
            matr[j, i] = elem;
        }
    }
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

void PrintMatrix(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          
         Console.Write($"{arr[i, j], 4}");
        }
         Console.WriteLine("|");
    }
    

}

