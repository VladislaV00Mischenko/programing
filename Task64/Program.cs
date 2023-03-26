﻿// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumber(number);

void NaturalNumber(int num)
{
    if(num == 1) Console.Write($"{num}");
    else Console.Write($"{num}, ");
    if(num == 1) return;
    NaturalNumber (num - 1);
    
}
