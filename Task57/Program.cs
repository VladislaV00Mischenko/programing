int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
int[] array = TransformationMatrToArray(matrix);
PrintArray(array);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
Dictionary(array);

void Dictionary(int[] arr)
{
    int value = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (value == arr[i]) count++;
    else 
    {
        Console.WriteLine($"{value} --> {count} ");
        value = arr[i];
        count = 1;
    }
    }
}


int[] TransformationMatrToArray(int[,] matr)
{
    int count = 0;
    int[] arr = new int[matr.Length];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[count++] = matr[i, j];
            
        }
    }
    return arr;
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