namespace Bank.Domain.Models
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount()
        {
            m_customerName = string.Empty;
            m_balance = 0;
        }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName ?? throw new ArgumentNullException(nameof(customerName), "Customer name cannot be null.");
            m_balance = balance;
        }

        public string CustomerName { get { return m_customerName; } }
        public double Balance { get { return m_balance; } }
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException(nameof(amount));
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            m_balance += amount;
        }
    }
}
