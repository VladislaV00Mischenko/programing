Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zA: ");
int zA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yB: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zB: ");
int zB = Convert.ToInt32(Console.ReadLine());



 double length = Distance(xA, yA, xB, yB, zA, zB);
 Console.WriteLine($"Расстояние между точками А и В = {Math.Round(length, 2, MidpointRounding.ToZero)}");

 double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1) );
}
