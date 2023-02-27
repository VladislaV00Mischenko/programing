//Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB) 
{
    Console.WriteLine($"Число {numberA} равно числу {numberB}");
}
else if (numberA > numberB)
{   
    Console.Write($"Число {numberA} больше числа {numberB}");
}
else 
{
    Console.Write($"Число {numberB} больше числа {numberA}");
}