using System.Net.Http.Json;

namespace MainService.Clients
{
    public class NumberClient
    {
        private readonly HttpClient _client;

        public NumberClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://localhost:5003"); // Порт NumberService
        }

        public async Task<string> SendNumberAsync(int number)
        {
            var response = await _client.PostAsJsonAsync("/numbers", number);
            return await response.Content.ReadAsStringAsync();
        }
    }
}