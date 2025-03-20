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