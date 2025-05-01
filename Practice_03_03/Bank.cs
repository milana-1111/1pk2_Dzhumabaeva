using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;

public static class Bank
{
    private static Dictionary<string, List<BankAccount>> clients = new();
    private const string FilePath = "clients.json";
    public static void LoadData()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            clients = JsonSerializer.Deserialize<Dictionary<string, List<BankAccount>>>(json) ?? new();
        }
    }
    public static void SaveData()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //настройки зписи json формат русского языка
        };
        string json = JsonSerializer.Serialize(clients, options);
        File.WriteAllText(FilePath, json);
    }
    public static void CreateClient(string fullName)
    {
        if (!clients.ContainsKey(fullName))
            clients[fullName] = new List<BankAccount>();
        else
            Console.WriteLine("Клиент уже существует.");
    }
    public static void CreateAccount(string fullName, AccountType type, decimal initialAmount)
    {
        if (clients.ContainsKey(fullName))
            clients[fullName].Add(new BankAccount { Type = type, Balance = initialAmount });
        else
            Console.WriteLine("Клиент не найден.");
    }
    public static void ShowAllClients()
    {
        Console.WriteLine("\n=== Все клиенты ===");
        foreach (var client in clients)
        {
            Console.WriteLine($"\nКлиент: {client.Key}");
            foreach (var acc in client.Value)
                Console.WriteLine($"\t{acc}");
        }
    }
    public static void ShowClientAccounts(string fullName)
    {
        if (clients.ContainsKey(fullName))
        {
            Console.WriteLine($"\nСчета клиента {fullName}:");
            foreach (var acc in clients[fullName])
                Console.WriteLine($"\t{acc}");
        }
        else Console.WriteLine("Клиент не найден.");
    }
    public static void ShowClientTotalBalance(string fullName)
    {
        if (clients.ContainsKey(fullName))
        {
            decimal sum = clients[fullName].Sum(acc => acc.Balance);
            Console.WriteLine($"\nОбщая сумма на счетах {fullName}: {sum:C}");
        }
    }
    public static void ShowAllTotalBalance()
    {
        decimal total = clients.Values.SelectMany(x => x).Sum(acc => acc.Balance);
        Console.WriteLine($"\nОбщая сумма на счетах всех клиентов: {total:C}");
    }
    public static void ShowAccountsByType(AccountType type)
    {
        Console.WriteLine($"\n=== {type} счета ===");
        foreach (var client in clients)
        {
            var filtered = client.Value.Where(acc => acc.Type == type).ToList();
            if (filtered.Any())
            {
                Console.WriteLine($"\nКлиент: {client.Key}");
                foreach (var acc in filtered)
                    Console.WriteLine($"\t{acc}");
            }
        }
    }
    public static void GenerateTestData(int count)
    {
        Random rnd = new();
        List<string> names = new() { "Иван", "Петр", "Алексей", "Сергей", "Дмитрий" };
        List<string> surnames = new() { "Иванов", "Петров", "Сидоров", "Козлов", "Смирнов" };
        List<string> patronymics = new() { "Сергеевич", "Александрович", "Петрович" };
        for (int i = 0; i < count; i++)
        {
            string fullName = $"{surnames[rnd.Next(surnames.Count)]} {names[rnd.Next(names.Count)]} {patronymics[rnd.Next(patronymics.Count)]}";
            CreateClient(fullName);

            int accountsCount = rnd.Next(1, 4);
            for (int j = 0; j < accountsCount; j++)
            {
                AccountType type = (AccountType)rnd.Next(0, 2);
                decimal balance = rnd.Next(1000, 100000);
                CreateAccount(fullName, type, balance);
            }
        }
    }
}