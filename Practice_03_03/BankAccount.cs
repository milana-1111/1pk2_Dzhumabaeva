using System;

public class BankAccount
{
    public AccountType Type { get; set; }
    public decimal Balance { get; set; }
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
            Balance -= amount;
        else
            Console.WriteLine("Недостаточно средств.");
    }
    public override string ToString()
    {
        return $"{Type} | Баланс: {Balance:C}";
    }
}