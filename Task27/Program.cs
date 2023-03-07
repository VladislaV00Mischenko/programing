﻿//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);

int SumDigit(int num)
{
   int sum = 0;
   int digit = 0;
    while (num != 0)

    {   
        digit = num % 10;
        num = num / 10;
        sum = sum + digit;
    }
    return sum;
}