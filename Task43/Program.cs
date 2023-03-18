//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите кофициент для первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите константу для первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кофициент для второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите константу для второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] coord = FindCoord(k1, b1, k2, b2);
PrintArray(coord);

double[] FindCoord(int x1, int y1, int x2, int y2)
{
double[] coord = new double[2];
 coord[0] = (y2 - y1) / (x1 - x2);
coord[1] = x1 * coord[0] + y1;
return coord;
}


void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}