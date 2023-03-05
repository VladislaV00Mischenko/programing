Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
for(int i = 1; i <= number; i++)
 {
    Console.WriteLine($"{i}  {i * i * i}");
 }
}
else
{
    Console.WriteLine("Некорректный ввод");
}