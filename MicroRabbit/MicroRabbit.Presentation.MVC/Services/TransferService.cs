using MicroRabbit.Presentation.MVC.Models.DTOs;
using Newtonsoft.Json;

namespace MicroRabbit.Presentation.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;

        public TransferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task TransferDtoAsync(TransferDto transferDto)
        {
            var response = await _httpClient.PostAsync("https://localhost:7045/api/banking", 
                                                        new StringContent(JsonConvert.SerializeObject(transferDto), 
                                                                          System.Text.Encoding.UTF8, 
                                                                          "application/json")
                                                        );
            response.EnsureSuccessStatusCode();
        }
    }
}
