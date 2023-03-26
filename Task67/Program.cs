Console.Write("Введите первое натуральное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = DigitSum(num);
Console.WriteLine(number);


int DigitSum(int num)
{
    if(num == 0) return 0;
    else return num % 10 + DigitSum(num / 10);
}