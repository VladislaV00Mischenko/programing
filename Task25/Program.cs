//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(numberA, numberB);
Console.WriteLine(degreeNumber);


int DegreeNumber(int numA, int numB)
{
    int sum = 1;
    for(int i = 0; i < numB; i++)
    {
        sum = sum * numA;
    }
    return sum;
}