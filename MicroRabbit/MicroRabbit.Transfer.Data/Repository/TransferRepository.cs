using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _transferDbContext;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            _transferDbContext = transferDbContext;
        }

        public void Add(TransferLog transferLog)
        {
            _transferDbContext.Add(transferLog);
        }

        public IEnumerable<TransferLog> GetAllTransferLogs()
        {
            return _transferDbContext.TransferLogs;
        }
    }
}
