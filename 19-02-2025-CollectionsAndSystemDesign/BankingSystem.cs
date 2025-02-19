using System;
using System.Collections.Generic;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>();
    private Queue<int> withdrawalQueue = new Queue<int>();

    public void CreateAccount(int accountNumber, double balance)
    {
        accountBalances[accountNumber] = balance;
    }

    public void RequestWithdrawal(int accountNumber)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            withdrawalQueue.Enqueue(accountNumber);
        }
    }

    public void ProcessWithdrawals()
    {
        while (withdrawalQueue.Count > 0)
        {
            int accountNumber = withdrawalQueue.Dequeue();
            Console.WriteLine("Processing withdrawal for account " + accountNumber);
        }
    }

    static void Main()
    {
        BankingSystem bank = new BankingSystem();
        bank.CreateAccount(101, 5000);
        bank.CreateAccount(102, 2000);
        bank.CreateAccount(103, 8000);

        bank.RequestWithdrawal(101);
        bank.RequestWithdrawal(103);

        bank.ProcessWithdrawals();
    }
}
