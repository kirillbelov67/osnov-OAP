using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        // Главный цикл while - игра повторяется
        while (playAgain)
        {
            Console.Clear();
            Console.WriteLine("=== ТЕКСТОВАЯ НОВЕЛЛА: ЖИЗНЬ СТУДЕНТА ===");
            Console.WriteLine("Ты проснулся утром в колледже.");
            Console.WriteLine("1. Идти в колледж");
            Console.WriteLine("2. Остаться дома");
            Console.WriteLine("3. Отчислиться");

            int a = GetValidInput(1, 3);

            // Используем switch для главного выбора
            switch (a)
            {
                case 1:
                    CollegeStory();
                    break;
                case 2:
                    HomeStory();
                    break;
                case 3:
                    DropoutStory();
                    break;
            }

            // Цикл for для обратного отсчета
            Console.Write("\nЗагрузка следующей игры");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine();

            // Спрашиваем, хочет ли игрок играть снова
            Console.WriteLine("\nХочешь попробовать другую концовку?");
            Console.WriteLine("1. Да, сыграть еще раз!");
            Console.WriteLine("2. Нет, выйти");

            int restartChoice = GetValidInput(1, 2);
            playAgain = (restartChoice == 1);
        }

        Console.WriteLine("\nСпасибо за игру! До встречи!");
    }

    // Функция с циклом while для проверки правильного ввода
    static int GetValidInput(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write($"\nВведите число от {min} до {max}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if (choice >= min && choice <= max)
                {
                    return choice;
                }
            }
            Console.WriteLine("Неверный ввод! Попробуйте снова.");
        }
    }

    static void CollegeStory()
    {
        Console.WriteLine("\nТы пошел на пару.");
        Console.WriteLine("1. Сидеть тихо");
        Console.WriteLine("2. Пошутить");
        int b = GetValidInput(1, 2);

        // Switch для выбора поведения на паре
        switch (b)
        {
            case 1:
                Console.WriteLine("\nПреподаватель вызывает тебя к доске.");
                Console.WriteLine("1. Ответить");
                Console.WriteLine("2. Молчать");
                int c = GetValidInput(1, 2);

                if (c == 1)
                {
                    Console.WriteLine("\nТы ответил правильно!");
                    Console.WriteLine("1. Сесть на место");
                    Console.WriteLine("2. Пойти пить чай");
                    int d = GetValidInput(1, 2);

                    if (d == 1)
                        Console.WriteLine("Конец 1: Ты молодец, день удался!");
                    else
                        Console.WriteLine("Конец 2: Ты ушел пить чай и пропустил все.");
                }
                else
                {
                    Console.WriteLine("\nПреподаватель злится.");
                    Console.WriteLine("1. Извиниться");
                    Console.WriteLine("2. Уйти");
                    int d = GetValidInput(1, 2);

                    if (d == 1)
                        Console.WriteLine("Конец 3: Тебя простили.");
                    else
                        Console.WriteLine("Конец 4: Тебя выгнали с пары.");
                }
                break;

            case 2:
                Console.WriteLine("\nВсе смеются, но преподаватель недоволен.");
                Console.WriteLine("1. Извиниться");
                Console.WriteLine("2. Сказать, что это шутка");
                int e = GetValidInput(1, 2);

                if (e == 1) Console.WriteLine("Конец 5: Преподаватель простил, день прошел спокойно.");
                else
                    Console.WriteLine("Конец 6: Тебе поставили выговор.");
                break;
        }
    }

    static void HomeStory()
    {
        Console.WriteLine("\nТы остался дома.");
        Console.WriteLine("1. Играть в компьютер");
        Console.WriteLine("2. Учить материал");
        int b = GetValidInput(1, 2);

        switch (b)
        {
            case 1:
                Console.WriteLine("\nТы заигрался.");

                // Цикл for для имитации игрового процесса
                Console.WriteLine("Проходит время...");
                for (int hours = 1; hours <= 5; hours++)
                {
                    Console.WriteLine($"Прошло {hours} часов игры");
                    System.Threading.Thread.Sleep(300);
                }

                Console.WriteLine("1. Продолжить");
                Console.WriteLine("2. Вспомнить о колледже");
                int c = GetValidInput(1, 2);

                if (c == 1)
                    Console.WriteLine("Конец 7: День прошел впустую.");
                else
                    Console.WriteLine("Конец 8: Ты успел на последнюю пару.");
                break;

            case 2:
                Console.WriteLine("\nТы стал готовиться заранее!");

                // Цикл for для показа процесса учебы
                Console.WriteLine("Ты учишься...");
                for (int topics = 1; topics <= 3; topics++)
                {
                    Console.WriteLine($"Изучена тема {topics} из 3");
                    System.Threading.Thread.Sleep(400);
                }

                Console.WriteLine("1. Повторить материал");
                Console.WriteLine("2. Отдохнуть");
                int d = GetValidInput(1, 2);

                if (d == 1)
                    Console.WriteLine("Конец 9: Ты стал лучшим студентом!");
                else
                    Console.WriteLine("Конец 10: Ты немного устал, но доволен собой.");
                break;
        }
    }

    static void DropoutStory()
    {
        Console.WriteLine("\nТы решил отчислиться.");
        Console.WriteLine("1. Писать заявление");
        Console.WriteLine("2. Передумать");
        int b = GetValidInput(1, 2);

        switch (b)
        {
            case 1:
                Console.WriteLine("\nТы подал заявление.");

                // Цикл for для обработки документов
                Console.WriteLine("Обработка документов...");
                for (int step = 1; step <= 4; step++)
                {
                    string[] steps = { "Подача заявления", "Подписание документов", "Одобрение декана", "Завершение процесса" };
                    Console.WriteLine(steps[step - 1]);
                    System.Threading.Thread.Sleep(500);
                }

                Console.WriteLine("1. Радоваться свободе");
                Console.WriteLine("2. Жалеть о решении");
                int c = GetValidInput(1, 2);

                if (c == 1)
                    Console.WriteLine("Конец 11: Ты свободен и счастлив!");
                else
                    Console.WriteLine("Конец 12: Ты пожалел о своем решении.");
                break;

            case 2:
                Console.WriteLine("\nТы решил остаться.");
                Console.WriteLine("1. Вернуться на учебу");
                Console.WriteLine("2. Уехать к бабушке");
                int d = GetValidInput(1, 2);

                if (d == 1)
                    Console.WriteLine("Конец 13: Ты снова студент!");
                else
                    Console.WriteLine("Конец 14: Ты отдыхаешь, но скучаешь по друзьям.");
                break;
        }
    }
}
