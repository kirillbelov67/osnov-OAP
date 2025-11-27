using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a == b)
            Console.WriteLine("Два числа равны");
        else if (a > b)
            Console.WriteLine("Первое число больше второго");
        else
            Console.WriteLine("Первое число меньше второго");
    }
}
