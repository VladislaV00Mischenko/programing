Console.Write("Введите первое натуральное целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int multiNum = MultiNum(num1, num2);
Console.WriteLine(multiNum);

int MultiNum(int num1, int num2)
{
    if(num2 == 0) return 1;
    else return checked(num1 * MultiNum(num1, num2 -1));
}
