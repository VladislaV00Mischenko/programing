Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{

int factorial = Factorial(number);
Console.WriteLine($"Факториал чисел от 1 до {number} = {factorial}");

}
else
{
    Console.WriteLine("Некоректный ввод");
}

int Factorial(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    {
        checked
        {
        sum = sum * i ;
        }
    }
    return sum;
}
