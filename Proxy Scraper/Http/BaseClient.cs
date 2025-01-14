using Newtonsoft.Json;

namespace Proxy_Scraper.Http;

public class BaseClient : IDisposable
{
    // Создание клиента
    private readonly HttpClient _client;
    // Базоый URL
    private readonly string _baseUrl;
    
    public BaseClient(string baseUrl)
    {
        _baseUrl = baseUrl;
        _client = new HttpClient
        {
            BaseAddress = new Uri(_baseUrl)
        };
        
        // Добавление заголовков
        _client.DefaultRequestHeaders.Add("Accept", "application/json");
        _client.DefaultRequestHeaders.Add("Origin", "https://proxyline.net");
        _client.DefaultRequestHeaders.Add("Referer", "https://proxyline.net/");
        _client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36");
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        string content = string.Empty;
        try
        {
            // Отправка GET запроса
            var response = await _client.GetAsync(endpoint);
            // Проверка статуса ответа
            response.EnsureSuccessStatusCode();

            // Чтение ответа
            content = await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            // Вывод ошибки в консоль
            Console.WriteLine(ex.Message);
        }
        
        // Десериализация и возврат ответа
        return JsonConvert.DeserializeObject<T>(content);
    }

    public void Dispose()
    {
        _client?.Dispose(); // Освобождаем
    }
}