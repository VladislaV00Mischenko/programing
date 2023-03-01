int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");

int delSecondDigit = DelSecondDigit(number);
 Console.WriteLine($"Первая и последняя цифра числа -> {delSecondDigit}");
int  DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}







