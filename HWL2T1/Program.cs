int GetSD(int number)
{
    return number / 10 % 10;
}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 1000)
{
    if (number > 99)
    {
       Console.WriteLine($"Вторая цифра числа {number} -> {GetSD(number)}"); 
    }
    else
    {
        if (number > -1000)
        {
            if (number < -99)
            {
               Console.WriteLine($"Вторая цифра числа {number} -> {GetSD(number) * -1}");  
            }
            else 
            {
                Console.WriteLine("Число не трехзначное");
            }
        }
    else 
    {
       Console.WriteLine("Число не трехзначное"); 
    }
    }
     
}
else 
{
    Console.WriteLine("Число не трехзначное");
}