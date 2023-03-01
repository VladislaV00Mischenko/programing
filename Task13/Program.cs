Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 99)
{
    Console.WriteLine("Третьей цифры нет");
    
}
else
{
    while(number > 1000)
    {
        number = number / 10;
    
    }

int friDigit = FriDigit(number);
Console.WriteLine(friDigit);
}

int FriDigit(int num)
{
    return num % 10;
}