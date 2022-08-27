int GetTD(int number)
{
    if (Math.Abs(number) > 99)
    {
      int result = 0;
      while (Math.Abs(number) > 999)
      number /= 10;
      result = number % 10; 
      return result;
    }
    else
    {
        Console.WriteLine("Третьего числа нет");
        return 0;
    }
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Третья цифра числа {number} -> {Math.Abs(GetTD(number))}"); 