int[,] matrix = CreateMatrixRndInt(4, 4,0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SquareEvenElement(matrix);
PrintMatrix(matrix);


void SquareEvenElement(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
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
