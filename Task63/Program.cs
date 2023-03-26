Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumber(number);

void NaturalNumber(int num)
{
    if(num == 0) return;
    NaturalNumber (num - 1);
    Console.Write($"{num} ");
}