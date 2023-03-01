Console.WriteLine("Введите натуральное трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <1000) 
{

int secondNumber = SecondNumber(number);
Console.WriteLine(secondNumber);
}
else 
{
    
Console.WriteLine("Должно быть целое трёхзначное число");
}

int SecondNumber(int num)
{
     int secondDigit = num / 10;
     secondDigit = secondDigit % 10;
     return secondDigit;
}
