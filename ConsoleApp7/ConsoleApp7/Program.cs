using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        int op = Convert.ToInt32(Console.ReadLine());
        double result;

        switch (op)
        {
            case 1:
                result = a + b;
                Console.WriteLine($"Результат: {result}");
                break;
            case 2:
                result = a - b;
                Console.WriteLine($"Результат: {result}");
                break;
            case 3:
                result = a * b;
                Console.WriteLine($"Результат: {result}");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
    }
}
