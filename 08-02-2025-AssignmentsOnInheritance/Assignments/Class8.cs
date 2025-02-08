using System; 

namespace Assignments
{
    // Base class
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("This is a generic bank account.");
        }
    }

    // Subclass: SavingsAccount
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"Savings Account - Account Number: {AccountNumber}, Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }

    // Subclass: CheckingAccount
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"Checking Account - Account Number: {AccountNumber}, Balance: {Balance}, Withdrawal Limit: ${WithdrawalLimit}");
        }
    }

    // Subclass: FixedDepositAccount
    class FixedDepositAccount : BankAccount
    {
        public int TermLength { get; set; } 

        public FixedDepositAccount(string accountNumber, double balance, int termLength)
            : base(accountNumber, balance)
        {
            TermLength = termLength;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"Fixed Deposit Account - Account Number: {AccountNumber}, Balance: {Balance}, Term Length: {TermLength} months");
        }
    }

    class Class8
    {
        public static void Main8()
        {
            BankAccount savings = new SavingsAccount("AB101", 1000, 5.2);
            BankAccount checking = new CheckingAccount("AB102", 2000, 2000);
            BankAccount fixedDeposit = new FixedDepositAccount("AB103", 3000, 18);

            savings.DisplayAccountType();
            checking.DisplayAccountType();
            fixedDeposit.DisplayAccountType();
        }
    }
}
