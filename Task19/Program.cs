﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool checkNumber = CheckNumber(number);
 Console.WriteLine(checkNumber ? "да": "нет");

 bool CheckNumber(int num)
 {
    int sum = 0;
    while(num != 0)
    {
         sum = sum * 10;
         sum = sum + num % 10;
         num = num / 10;
     }

    return sum == number;
    // int num1 = num / 10000;
    // int num5 = num % 10;
    // int num2 = num / 1000;
    // num2 = num2 % 10;
    // int num4 = num/ 10 ;
    // num4 = num4 % 10;
    // return num1 == num5 && num2 == num4;
 }
