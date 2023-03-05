Console.WriteLine("Введите номер четверти координат");
string quarterNum = Console.ReadLine();

string cord = Cord(quarterNum);
Console.WriteLine(cord);





string Cord(string quad )
{
  if(quad == "1") return "x > 0, y > 0";
  if(quad == "2") return "x < 0, y > 0";
  if(quad == "3") return "x < 0, y < 0";
  if(quad == "4") return "x > 0, y < 0";
  return "неправельный ввод";
}