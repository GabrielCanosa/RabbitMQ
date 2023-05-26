using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Aplication.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
