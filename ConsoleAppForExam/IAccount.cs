namespace ConsoleAppForExam
{
    public interface IAccount
    {
        decimal Balance { get; }

        void Deposite(decimal ammount);
        decimal withdraw(decimal ammout);
    }
}