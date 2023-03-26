Console.Write("Введите первое натуральное целое число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное целое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
NaturalNum(numM,numN);

void NaturalNum(int num1, int num2)
{
    if(num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNum(num1 - 1, num2);
        
    }
   else if(num1 < num2)
    {
       
        NaturalNum (num1, num2 - 1);
        Console.Write($"{num2} ");
       
    }
   else 
    {
    Console.WriteLine($"{num2} ");
    }
}