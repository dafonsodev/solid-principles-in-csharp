namespace _2_OCP.Following.Extensions
{
    public static class DebitInSavingAccountExtension
    {
        public static string DebitarInSavingAccount(this DebitInAccountGood debitInAccount)
        {
            debitInAccount.Balance -= debitInAccount.Amount;
            return debitInAccount.Process();
        }
    }
}
