using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bank.LoadData();
        Console.WriteLine("Добро пожаловать в консольный банк!");
        if (!File.Exists("clients.json"))
        {
            Console.WriteLine("Генерация тестовых данных...");
            Bank.GenerateTestData(10);
            Bank.SaveData();
        }
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Показать всех клиентов");
            Console.WriteLine("2. Показать счета клиента");
            Console.WriteLine("3. Общая сумма по счетам клиента");
            Console.WriteLine("4. Общая сумма по всем счетам");
            Console.WriteLine("5. Только кредитные счета");
            Console.WriteLine("6. Только дебетовые счета");
            Console.WriteLine("7. Создать нового клиента");
            Console.WriteLine("8. Добавить счет клиенту");
            Console.WriteLine("0. Выход");
            Console.Write("Выбор: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Bank.ShowAllClients();
                    break;
                case "2":
                    Console.Write("Введите ФИО: ");
                    Bank.ShowClientAccounts(Console.ReadLine());
                    break;
                case "3":
                    Console.Write("Введите ФИО: ");
                    Bank.ShowClientTotalBalance(Console.ReadLine());
                    break;
                case "4":
                    Bank.ShowAllTotalBalance();
                    break;
                case "5":
                    Bank.ShowAccountsByType(AccountType.Credit);
                    break;
                case "6":
                    Bank.ShowAccountsByType(AccountType.Debit);
                    break;
                case "7":
                    Console.Write("Введите ФИО: ");
                    Bank.CreateClient(Console.ReadLine());
                    Bank.SaveData();
                    break;
                case "8":
                    Console.Write("Введите ФИО клиента: ");
                    string fio = Console.ReadLine();
                    Console.Write("Тип счета (0 - Дебетовый, 1 - Кредитный): ");
                    var type = (AccountType)int.Parse(Console.ReadLine());
                    Console.Write("Начальная сумма: ");
                    decimal sum = decimal.Parse(Console.ReadLine());
                    Bank.CreateAccount(fio, type, sum);
                    Bank.SaveData();
                    break;
                case "0":
                    Bank.SaveData();
                    return;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}