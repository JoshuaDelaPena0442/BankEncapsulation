namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            Console.WriteLine("Enter amount to deposit: ");

            var depositAmount = double.Parse(Console.ReadLine());
            
            account.Deposit(depositAmount);
            
            Console.WriteLine($"This is now your current balance: ${account.GetBalance()}");
        }
    }
}
