using System;

namespace _5pr
{
    public class DepositAccount : BankAccount
    {
        public double InterestRate { get; set; }
    
        public DepositAccount(string accountNumber, string owner, double balance, double interestRate)
            : base(accountNumber, owner, balance)
        {
            InterestRate = interestRate;
        }
    
        public override void DepositMoney(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Депозит поповнено на {amount} UAH. Новий баланс: {Balance} UAH.");
        }
    
        public override void WithdrawMoney(double amount)
        {
            Console.WriteLine("Зняття коштів із депозиту неможливе до завершення терміну зберігання");
        }
    
        public void ApplyInterest()
        {
            double profit = Balance * InterestRate / 100;
            Balance += profit;
            Console.WriteLine($"Нараховано: {InterestRate}% ({profit} UAH). Новий баланс: {Balance} UAH.");
        }
    }
}