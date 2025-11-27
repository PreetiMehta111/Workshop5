namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount("12345987654", 1000);

            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Opening Balance: {account.Balance}");

            account.Deposit(26895302);
            account.Withdraw(50000);

            Console.WriteLine($"Remaining Balance: {account.Balance}");
        }
    }
}