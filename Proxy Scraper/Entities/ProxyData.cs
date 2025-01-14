using Newtonsoft.Json;

namespace Proxy_Scraper.Entities;

public class ProxyData
{
    [JsonProperty("ip")]
    public string Ip { get; set; }
    
    [JsonProperty("port")]
    public string Port { get; set; }
    
    [JsonProperty("protocol")]
    public string Protocol { get; set; }
    
    [JsonProperty("anonymity")]
    public string Anonymity { get; set; }
    
    [JsonProperty("https")]
    public bool Https { get; set; }
    
    [JsonProperty("country")]
    public string Country { get; set; }
    
    [JsonProperty("city")]
    public string City { get; set; }
}