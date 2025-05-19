using System.Net.Http.Json;
using MainService.Models;

public class TextClient
{
    private readonly HttpClient _client;

    public TextClient(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("http://localhost:5002");
    }

    public async Task<string> SendTextAsync(string text)
    {
        var dto = new TextRequestDto { Text = text };
        var response = await _client.PostAsJsonAsync("/texts", dto);
        return await response.Content.ReadAsStringAsync();
    }
}