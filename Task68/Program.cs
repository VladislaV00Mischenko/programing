// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое натуральное целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int akkerman = AkkermanFunction(numberA, numberB);
Console.WriteLine(akkerman);


int AkkermanFunction(int num1, int num2)
{
   if( num1 == 0) return num2 + 1;
   else if ( num2 == 0) return AkkermanFunction (num1 - 1, 1);
   else return AkkermanFunction(num1 - 1, AkkermanFunction (num1, num2 - 1));
}