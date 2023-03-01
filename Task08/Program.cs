//Напишите программу, которая на вход принимает(N), а на выходе показывает все четные числа от 1 до N.


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
 for(int i = 2; i <= number; i += 2)
   {
      Console.WriteLine(i + " ");
   }
}
else
{
    Console.WriteLine("Число должно быть положительным");
}