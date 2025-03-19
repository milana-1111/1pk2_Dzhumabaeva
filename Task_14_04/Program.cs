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
public class User
{
    // Статическое свойство для хранения текущего пользователя
    public static string CurrentUser { get; private set; }
    // Метод
    public static void SetCurrentUser(string username)
    {
        CurrentUser = username;
    }
}