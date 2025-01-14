using Proxy_Scraper.Entities;
using Proxy_Scraper.Extenstions;
using Proxy_Scraper.Http;

namespace Proxy_Scraper.Scraper;

public class Scraper
{
    public async Task<List<ProxyData>> Scrape()
    {
        using (var client = new BaseClient("https://api.proxy-checker.net"))
        {
            // Получаем список проксей\
            var proxies = client.GetAsync<List<ProxyData>>("/api/free-proxy-list/");
            // Поулчаем список проксей
            var result = proxies.Result;
            // Возвращаем список проксей
            return result;
        }
    }
}