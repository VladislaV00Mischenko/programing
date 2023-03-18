int[,] matrix = CreateMatrixRndInt(8, 8, 0, 100);
PrintMatrix(matrix);
int sumDiogonalElement = SumElementDioganal(matrix);
Console.WriteLine($"Сумма элементов главной диогонали = {sumDiogonalElement}");


int SumElementDioganal(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == j) sum += matr[i, j];
        } 
    }
    return sum;
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

