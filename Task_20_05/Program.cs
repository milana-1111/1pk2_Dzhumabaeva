namespace Task_20_05
{

    class Program
    {
        static void Main(string[] args)
        {
            AccessLevel userAccessLevel = AccessLevel.Moderator; // Пример уровня 

            string action = "удалить пост"; // Пример действия

            CheckAccess(userAccessLevel, action);
        }
        static void CheckAccess(AccessLevel accessLevel, string action)
        {
            switch (action)
            {
                case "удалить пост":
                    if (accessLevel == AccessLevel.Admin || accessLevel == AccessLevel.Moderator)
                    {
                        Console.WriteLine("Ошибка: Недостаточно прав!");
                    }
                    else
                    {
                        Console.WriteLine("Действие разрешено: пост был удален");
                    }
                    break;

                default:
                    Console.WriteLine("Действие не распознано.");
                    break;
            }
        }
    }
}