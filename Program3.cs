using System;

namespace _5pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CurrentAccount webber = new CurrentAccount("12345", "Григоренко", 5000);
            webber.CreateAccount();
            webber.DepositMoney(1500);
            webber.WithdrawMoney(2000);
            webber.ShowInfo();
    
            Console.WriteLine();
    
            DepositAccount batter = new DepositAccount("12346", "Колоскова", 10000, 8);
            batter.CreateAccount();
            batter.ApplyInterest();
            batter.WithdrawMoney(2000);
            batter.ShowInfo();
    
            Console.WriteLine();
    
            current.DeleteAccount();
            deposit.DeleteAccount();
        }
    }
}