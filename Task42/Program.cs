Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinareCode(number));


string BinareCode(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}
