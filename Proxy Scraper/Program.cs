using Proxy_Scraper.Console_menu;
using Proxy_Scraper.Extenstions;

namespace Proxy_Scraper;

class Program
{
    
    static async Task Main(string[] args)
    {
        // Инициализируем парсер
        var scraper = new Scraper.Scraper();
        // Парсим прокси
        var proxyList = await scraper.Scrape();
        
        // Вывод прокси на консоль
        proxyList.PrintToConsole();
        
        // Вывод меню
        Menu.ShowMenu();
        
        // Читаем ввод
        while (true)
        {
            // Считываем нажатую клавишу
            var inputKey = Console.ReadKey().KeyChar;
            
            // Обрабатываем
            await Menu.HandleUserInput(inputKey, proxyList);
        }
    }
}