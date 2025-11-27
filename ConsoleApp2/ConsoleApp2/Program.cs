using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num > 5 && num < 10)
            Console.WriteLine("Число больше 5 и меньше 10");
        else
            Console.WriteLine("Неизвестное число");
    }
}