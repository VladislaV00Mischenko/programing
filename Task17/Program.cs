//напишите программу, которая принимает 
// 1. на вход координаты точки(X и Y),
// 2. причем X != 0 и Y != 0 и 
// 3. выдает номер четверти плоскости, в которой находится точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
           ? $"Указанные координаты соотвецтвуют четверти - {quarter}"
           : "Введены некорректные координаты ";

Console.WriteLine(result);

int Quarter(int x, int y)
{
  if(x > 0 && y > 0) return 1;
  if(x < 0 && y > 0) return 2;
  if(x < 0 && y < 0) return 3;
  if(x > 0 && y < 0) return 4;
  return 0;


}
