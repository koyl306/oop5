using System;

namespace _5pr
{
    public abstract class BankAccount : IAccountActions
    {
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
        public double Balance { get; protected set; }
    
        public BankAccount(string accountNumber, string owner, double balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }
    
        public void CreateAccount()
        {
            Console.WriteLine($"Створено рахунок #{AccountNumber} для {Owner} з балансом {Balance} UAH.");
        }
    
        public void DeleteAccount()
        {
            Console.WriteLine($"Рахунок #{AccountNumber} ({Owner}) видалено.");
        }
    
        public abstract void DepositMoney(double amount);
        public abstract void WithdrawMoney(double amount);
    
        public void ShowInfo()
        {
            Console.WriteLine($"Рахунок #{AccountNumber} | Власник: {Owner} | Баланс: {Balance} UAH");
        }
    }
}