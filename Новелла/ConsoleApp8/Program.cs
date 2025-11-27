using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ты проснулся утром в колледж.");
        Console.WriteLine("1. Идти в колледж");
        Console.WriteLine("2. Остаться дома");
        Console.WriteLine("3. Отчислиться");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a == 1)
        {
            Console.WriteLine("Ты пошёл на пару.");
            Console.WriteLine("1. Сидеть тихо");
            Console.WriteLine("2. Пошутить");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 1)
            {
                Console.WriteLine("Преподаватель вызывает тебя к доске.");
                Console.WriteLine("1. Ответить");
                Console.WriteLine("2. Молчать");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine("Ты ответил правильно!");
                    Console.WriteLine("1. Сесть на место");
                    Console.WriteLine("2. Пойти пить чай");
                    int d = Convert.ToInt32(Console.ReadLine());

                    if (d == 1) Console.WriteLine("Конец 1: Ты молодец, день удался!");
                    else Console.WriteLine("Конец 2: Ты ушёл пить чай и пропустил всё.");
                }
                else
                {
                    Console.WriteLine("Преподаватель злится.");
                    Console.WriteLine("1. Извиниться");
                    Console.WriteLine("2. Уйти");
                    int d = Convert.ToInt32(Console.ReadLine());

                    if (d == 1) Console.WriteLine("Конец 3: Тебя простили.");
                    else Console.WriteLine("Конец 4: Тебя выгнали с пары.");
                }
            }
            else
            {
                Console.WriteLine("Все смеются, но преподаватель недоволен.");
                Console.WriteLine("1. Извиниться");
                Console.WriteLine("2. Сказать, что это шутка");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1) Console.WriteLine("Конец 5: Преподаватель простил, день прошёл спокойно.");
                else Console.WriteLine("Конец 6: Тебе поставили выговор.");
            }
        }
        else if (a == 2)
        {
            Console.WriteLine("Ты остался дома.");
            Console.WriteLine("1. Играть в компьютер");
            Console.WriteLine("2. Учить материал");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 1)
            {
                Console.WriteLine("Ты заигрался.");
                Console.WriteLine("1. Продолжить");
                Console.WriteLine("2. Вспомнить о колледже");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1) Console.WriteLine("Конец 7: День прошёл впустую.");
                else Console.WriteLine("Конец 8: Ты успел на последнюю пару.");
            }
            else
            {
                Console.WriteLine("Ты стал готовиться заранее!");
                Console.WriteLine("1. Повторить материал");
                Console.WriteLine("2. Отдохнуть");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1) Console.WriteLine("Конец 9: Ты стал лучшим студентом!");
                else Console.WriteLine("Конец 10: Ты немного устал, но доволен собой.");
            }
        }
        else if (a == 3)
        {
            Console.WriteLine("Ты решил отчислиться.");
            Console.WriteLine("1. Писать заявление");
            Console.WriteLine("2. Передумать");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 1)
            {
                Console.WriteLine("Ты подал заявление.");
                Console.WriteLine("1. Радоваться свободе");
                Console.WriteLine("2. Жалеть о решении");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1) Console.WriteLine("Конец 11: Ты свободен и счастлив!");
                else Console.WriteLine("Конец 12: Ты пожалел о своём решении.");
            }
            else
            {
                Console.WriteLine("Ты решил остаться.");
                Console.WriteLine("1. Вернуться на учёбу");
                Console.WriteLine("2. Уехать к бабушке");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1) Console.WriteLine("Конец 13: Ты снова студент!");
                else Console.WriteLine("Конец 14: Ты отдыхаешь, но скучаешь по друзьям.");
            }
        }
        else
        {
            Console.WriteLine("Такого выбора нет. Конец 15: Ошибка судьбы :)");
        }
    }
}