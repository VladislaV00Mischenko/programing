Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumber}");



int SumNumber(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}