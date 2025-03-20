namespace Task_14_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определите класс User, который будет иметь статическое свойство CurrentUser,
            //представляющеетекущегопользователя, и метод для его установки.
            User.SetCurrentUser("Милана");
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser}");
            User.SetCurrentUser("Лера");
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser}");
        }
    }
}
