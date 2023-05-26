namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int AcountFrom { get; set; }
        public int ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
