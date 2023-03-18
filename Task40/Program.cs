Console.Write("Введите размер первой стороны: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер второй стороны: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер третьей стороны: ");
int size3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(TriangleCheck(size1, size2, size3) ? "Да" : "Нет");



bool TriangleCheck(int numA, int numB, int numC)
{
    return numA + numB > numC && numA + numC > numB && numB + numC > numA;
    
}