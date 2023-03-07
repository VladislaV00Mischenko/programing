//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    CubeNum(number);
}
else
{
    Console.WriteLine("Некорректный ввод");
}
void CubeNum(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}  {i * i * i}");
    }
}