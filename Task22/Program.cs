Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
{
Square(num);
}

else
{
  Console.WriteLine("Введено некоректное число");
}
void Square(int number)
{
for(int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i, 4} -> {i * i, 4}");
    
}

}