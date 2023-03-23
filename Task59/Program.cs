int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = MinElemIndexes(matrix);
int[,] newMatrix = DelMinRowColumn(matrix, array[0], array[1]);
PrintMatrix(newMatrix);


int[,] DelMinRowColumn(int[,] matr, int rowDel, int columnDel)
{
    int[,] newMatr = new int[matr.GetLength(0)- 1, matr.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        if(m == rowDel) m++;
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            if(n == columnDel) n++;
            newMatr[i, j] = matr[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newMatr;
}
int[]  MinElemIndexes(int[,] matr)
{
    int row = 0, column = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] < matr[row, column]) 
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[]{row, column};
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

