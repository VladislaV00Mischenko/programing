Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
// int ost = numberA % numberB;
// if(ost == 0 )
// {
//     Console.WriteLine($"{numberA} кратно {numberB}");
// }
// else 
// {
   
//     Console.WriteLine($"{numberA} не кратно {numberB} остаток {ost}");
// }


 int qvadDigit = Metod(numberA, numberB);

 int Metod(int numberA, int numberB)
 {
      int result = numberA % numberB;

      return result;
 }
  if(qvadDigit == 0)
 {
    Console.WriteLine($"{numberA} кратно {numberB}");
 }
else 
 {
    int ost = numberA % numberB;
    Console.WriteLine($"{numberA} не кратно {numberB} остаток {ost}");
}