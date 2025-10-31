using System;

class Accounts
{
    double accountsNumber;
    double balance;
    string holderName;
    public Accounts(double accountsNumber, double balance, string holderName)
    {
        this.accountsNumber = accountsNumber;
        this.balance = balance;
        this.holderName = holderName;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Successfully deposited {amount}. Current Balance: {balance}.");
    }
    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance, Unable to complete the process");
        }
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Sir your Account Number is {accountsNumber} with Accountholder name {holderName} has current balance of {balance}\nThank you");
    }
}