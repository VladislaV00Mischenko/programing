Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 8)
{
    bool dayNumber = DayNumber(number);
    Console.WriteLine(dayNumber ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}





bool DayNumber(int num)
{
    return number > 5;
}