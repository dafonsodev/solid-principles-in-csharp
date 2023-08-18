namespace _2_OCP.Following.Extensions
{
    public static class DebitInCheckingAccountExtension
    {
        public static string ToDebitInCheckingAccount(this DebitInAccountGood debitInAccount)
        {
            debitInAccount.Balance -= debitInAccount.Amount;
            return debitInAccount.Process();
        }
    }
}
