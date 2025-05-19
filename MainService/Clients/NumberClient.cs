using System.Net.Http.Json;
using MainService.Models;

public class NumberClient
{
    private readonly HttpClient _client;

    public NumberClient(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("http://localhost:5003");
    }

    public async Task<string> SendNumberAsync(int number)
    {
        var dto = new NumberRequestDto { Number = number };
        var response = await _client.PostAsJsonAsync("/numbers", dto);
        return await response.Content.ReadAsStringAsync();
    }
}