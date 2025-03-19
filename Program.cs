class Program
{
    static void Main(string[] args)
    {
        string selection = "";
        double balance = 0;
        do
        {
            Console.WriteLine("1. Balance Inquiry\n2. Deposit\n3. Withdraw\n4. Checkout");
            Console.Write("Select an operation: ");
            selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine($"Balance: {balance} $ ");
                    break;
                case "2":
                    int depositedMoney = Convert.ToInt32(Console.ReadLine());
                    if (depositedMoney <= 0)
                    {
                        Console.WriteLine("Invalid Amount");
                    }
                    else
                    {
                        balance += depositedMoney;
                        Console.WriteLine("Deposit successful");
                    }
                    break;
                case "3":
                    int withdrawnMoney = Convert.ToInt32(Console.ReadLine());
                    if (withdrawnMoney > balance)
                    {
                        Console.WriteLine("Insufficient Balance");
                    }
                    else
                    {
                        balance -= withdrawnMoney;
                        Console.WriteLine("Withdrawal successful");
                    }
                    break;
                case "4":
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        } while (selection != "4");
        Console.WriteLine("Exit Executed");
    }
}
