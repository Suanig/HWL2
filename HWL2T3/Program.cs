string[] WeekDay = {"Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday", "Sunday" };
Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = int.Parse(Console.ReadLine());

if (number > 5)
    {
        Console.WriteLine($"{WeekDay[number - 1]} - Выходной");
    }
else 
{
    Console.WriteLine($"{WeekDay[number - 1]} - Не выходной");
}