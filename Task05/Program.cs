Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0) 
{
    for(int i = -number; i <= number; i++)
   {
      Console.WriteLine(i + " ");
   }
}
else
{
    Console.WriteLine("Должно быть положительное целое число");
}
