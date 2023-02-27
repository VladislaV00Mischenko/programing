//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine($"число {number} является четным");
}
else 
{
    Console.WriteLine($"Число {number} не является четным");
}