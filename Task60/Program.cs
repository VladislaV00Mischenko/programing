// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] cube = new int[2, 2, 2];
if(cube.Length < 90)
{
FillArrayCube(cube);
PrintArrayCube(cube);
}
else Console.WriteLine("Количество элементов массива больше неповторяющихся двузначных чисел");

void FillArrayCube(int[,,] cube)
{
     int num = 10;
    for(int i = 0;i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for(int z = 0; z < cube.GetLength(2); z++)
            {
                cube[i, j, z] = num++;
            }
        }
    }
}

void PrintArrayCube(int[,,] cube)
{
    for(int i = 0; i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for(int k = 0; k < cube.GetLength(2); k++)
            {
            Console.Write($"{cube[i, j, k]}({i},{j}, {k}) ");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}