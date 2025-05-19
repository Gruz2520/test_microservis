using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
        var content = new StringContent(text, Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/texts", content);

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Ошибка: {response.StatusCode} - {(int)response.StatusCode}");
            return "Ошибка при отправке текста";
        }

        return await response.Content.ReadAsStringAsync();
    }
}