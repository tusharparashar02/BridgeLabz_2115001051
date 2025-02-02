class BankAccount
{
    public int AccountNumber { get; set; }
    protected string AccountHolder { get; set; }
    private double Balance;

    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public double GetBalance()
    {
        return Balance;
    }

    public void SetBalance(double balance)
    {
        Balance = balance;
    }
}

// SavingsAccount Class
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        InterestRate = interestRate;
    }
}