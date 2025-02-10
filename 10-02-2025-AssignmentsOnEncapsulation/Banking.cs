using System;
using System.Collections.Generic;

abstract class BankAccount
{
    protected string accountNumber;
    
    protected string holder;
    
    protected double balance;

    public string AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
    
    public string Holder { get { return holder; } set { holder = value; } }
    
    public double Balance { get { return balance; } protected set { balance = value; } }

    public BankAccount(string num, string h, double bal)
    {
        accountNumber = num;
        holder = h;
        balance = bal;
    }

    public void Deposit(double a)
    {
        balance += a;
    }

    public virtual void Withdraw(double a)
    {
        if (a <= balance)
        
            balance -= a;
        else
            Console.WriteLine("Insufficient funds");
    }

    public abstract double CalcInt();
}

interface ILoanable
{
    void ApplyLoan(double a);
    
    bool CalcLoanElig();
}

class SavingsAcc : BankAccount, ILoanable
{
    public SavingsAcc(string num, string h, double bal) : base(num, h, bal) { }

    public override double CalcInt()
    {
        return balance * 0.04;
    }

    public void ApplyLoan(double a)
    {
        Console.WriteLine("Loan applied for: " + a);
    }

    public bool CalcLoanElig()
    {
        return balance > 5000;
    }
}

class CurrentAcc : BankAccount
{
    public CurrentAcc(string num, string h, double bal) : base(num, h, bal) { }

    public override double CalcInt()
    {
        return balance * 0.02;
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accts = new List<BankAccount>();
        
        accts.Add(new SavingsAcc("T123", "Tushar", 9000));
        
        accts.Add(new CurrentAcc("T124", "Parashar", 8000));
        

        foreach (BankAccount acct in accts)
        {
            Console.WriteLine("Account: " + acct.AccountNumber + ", Holder: " + acct.Holder + ", Interest: " + acct.CalcInt());
        }
    }
}