/*
 * Name: Zulisa Rodriguez
 * Course: CSC242 Object-Oriented Programming
 * Assignment: 4.1 Part II - BankAccountTester
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        Console.WriteLine("Initial Balance: " + account.Balance.ToString("C"));

        account.Deposit(500);

        Console.WriteLine("After Depositing $500: " + account.Balance.ToString("C"));

        account.Withdraw(150);

        Console.WriteLine("After Withdrawing $150: " + account.Balance.ToString("C"));

        Console.ReadLine();
    }
}