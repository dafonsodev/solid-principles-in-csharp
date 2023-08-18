namespace _2_OCP.Violating
{
    public class DebitInAccountBad
    {
        public string NumberAccount { get; set; }
        public decimal Balance { get; set; } = 500;
        public decimal Amount { get; set; }

        public string Process(DebitsType debitType, string accountNumber, decimal amount)
        {
            if (debitType == DebitsType.CheckingAccount)
            {
                Balance -= amount;
            }

            if (debitType == DebitsType.SavingAccount)
            {
                Balance -= amount;
            }

            return "Processed";
        }
    }
}
