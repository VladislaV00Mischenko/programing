Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int numDigit = NumDigit(number);
Console.WriteLine($"количество цифр в числе {number} = {numDigit}");


int NumDigit(int num)
{
    int i = 0;
    while( num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}