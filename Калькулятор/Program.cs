using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Простой калькулятор ===");

        // --- Ввод данных ---
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n=== Результаты вычислений ===");

        // --- Арифметические операции ---
        Console.WriteLine($"Сложение: {a} + {b} = {a + b}");
        Console.WriteLine($"Вычитание: {a} - {b} = {a - b}");
        Console.WriteLine($"Умножение: {a} * {b} = {a * b}");
        Console.WriteLine($"Деление: {a} / {b} = {a / b}");
        Console.WriteLine($"Остаток от деления: {a} % {b} = {a % b}");

        // --- Инкремент и декремент ---
        Console.WriteLine($"\nИнкремент первого числа (++a): {++a}");
        Console.WriteLine($"Декремент второго числа (--b): {--b}");

        // --- Логические операции ---
        Console.WriteLine("\n=== Логические операции ===");

        // Логическое И  - &&
        bool iRezultat = (a > 0) && (b > 0);
        Console.WriteLine($"Оба числа больше нуля: {iRezultat}");

        // Логическое ИЛИ  - ||
        bool iliRezultat = (a > 10) || (b > 10);
        Console.WriteLine($"Хотя бы одно число больше 10: {iliRezultat}");

        // Логическое НЕ  - !
        bool neRezultat = !(a == b);
        Console.WriteLine($"Числа не равны между собой: {neRezultat}");

        Console.WriteLine("\n=== Конец работы программы ===");
    }
}