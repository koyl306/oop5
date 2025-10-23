using System;

namespace _5pr
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountNumber, string owner, double balance)
            : base(accountNumber, owner, balance)
        {
        }
    
        public override void DepositMoney(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Поточний рахунок поповнено на {amount} UAH. Новий баланс: {Balance} UAH.");
        }
    
        public override void WithdrawMoney(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"З рахунку знято {amount} UAH. Залишок: {Balance} UAH.");
            }
            else
            {
                Console.WriteLine("Недостатньо коштів на поточному рахунку");
            }
        }
    }
}