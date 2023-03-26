// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
     int sumDigit = SumDigit(numberB, numberA);
     Console.WriteLine(sumDigit);
}
else if(numberA < numberB)
{
    int sumDigit = SumDigit(numberA, numberB);
    Console.WriteLine(sumDigit);
}
else Console.WriteLine(numberA);

int SumDigit(int num1, int num2)
{
    
    if(num1 == num2) return num1;
    else return num2 + SumDigit(num1, num2 - 1);
}