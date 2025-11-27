using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Вы выбрали операцию: Сложение");
                break;
            case 2:
                Console.WriteLine("Вы выбрали операцию: Вычитание");
                break;
            case 3:
                Console.WriteLine("Вы выбрали операцию: Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
    }
}
