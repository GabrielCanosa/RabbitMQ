using MicroRabbit.Presentation.MVC.Models.DTOs;

namespace MicroRabbit.Presentation.MVC.Services
{
    public interface ITransferService
    {
        Task TransferDtoAsync(TransferDto transferDto);
    }
}
