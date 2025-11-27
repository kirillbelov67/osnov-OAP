using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double sum = Convert.ToDouble(Console.ReadLine());
        double percent = 0;

        if (sum < 100)
            percent = 0.05;
        else if (sum <= 200)
            percent = 0.07;
        else
            percent = 0.10;

        sum += sum * percent;
        Console.WriteLine($"Сумма вклада с процентами: {sum}");
    }
}
