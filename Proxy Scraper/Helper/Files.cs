using Proxy_Scraper.Entities;

namespace Proxy_Scraper.Helper;

public class Files
{
    public static async Task SaveToFile(List<ProxyData> proxyList)
    {
        await using (var stream = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "proxies.txt")))
        {
            foreach (var proxy in proxyList)
                await stream.WriteLineAsync($"{proxy.Ip}:{proxy.Port}");
        } 
    }
}