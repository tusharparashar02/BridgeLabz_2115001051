using System;
using System.Collections.Generic;

namespace Assignments
{
    // Bank Account class
    class BankAccount{
        public string AccountNumber { get; set; }
        public double Balance { get; private set; }
        public Bank Bank { get; private set; }
        public BankAccount(string accountNumber, Bank bank){
            AccountNumber = accountNumber;
            Bank = bank;
            Balance = 0;
        }
        public void Deposit(double amount){
            Balance += amount;
        }
        public void Withdraw(double amount){
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient balance.");
        }
        public void ViewBalance(){
            Console.WriteLine("Account " + AccountNumber + " Balance: " + Balance);
        }
    }

    // Customer class
    class Customer{
        public string Name { get; set; }
        public List<BankAccount> Accounts { get; private set; } = new List<BankAccount>();
        public Customer(string name){
            Name = name;
        }
        public void OpenAccount(Bank bank, string accountNumber){
            BankAccount newAccount = new BankAccount(accountNumber, bank);
            Accounts.Add(newAccount);
            bank.AddAccount(newAccount);
        }
        public void ViewAllBalances(){
            Console.WriteLine("Accounts for " + Name + ":");
            foreach (var account in Accounts){
                account.ViewBalance();
            }
            Console.WriteLine("");
        }
    }
    // Bank class
    class Bank{
        public string BankName { get; set; }
        public List<BankAccount> Accounts { get; private set; } = new List<BankAccount>();
        public Bank(string bankName){
            BankName = bankName;
        }
        public void AddAccount(BankAccount account){
            Accounts.Add(account);
        }
    }
    // Main Program
    class main{
        public static void Main(){
            // Create a Bank
            Bank bank = new Bank("National Bank");
            // Create Customers
            Customer customer1 = new Customer("Customer1");
            Customer customer2 = new Customer("Customer2");
            // Open Accounts
            customer1.OpenAccount(bank, "A123");
            customer2.OpenAccount(bank, "B456");
            customer2.OpenAccount(bank, "B789");
            // Deposit Money
            customer1.Accounts[0].Deposit(500);
            customer2.Accounts[0].Deposit(1000);
            customer2.Accounts[1].Deposit(1500);
            // View Balances
            customer1.ViewAllBalances();
            customer2.ViewAllBalances();
        }
    }
}