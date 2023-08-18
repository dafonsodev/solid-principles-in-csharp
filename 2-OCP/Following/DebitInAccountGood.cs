namespace _2_OCP.Following
{
    public class DebitInAccountGood

    {
        public string NumberAccount { get; set; }
        public decimal Balance { get; set; } = 500;
        public decimal Amount { get; set; }

        public string Process()
        {
            return "Processed";
        }
    }
}
