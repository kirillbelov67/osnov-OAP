using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num == 5 || num == 10)
            Console.WriteLine("Число либо равно 5, либо равно 10");
        else
            Console.WriteLine("Неизвестное число");
    }
}
