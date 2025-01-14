using Proxy_Scraper.Entities;

namespace Proxy_Scraper.Extenstions;

public static class ProxyListExtensions
{
    // Опеределяем ширину колонок
    private const int ipWidth = 15;
    private const int portWidth = 10;
    private const int loactiontWidth = 25;
    private const int protocolWidth = 10;
    private const int anonimitylWidth = 25;
    
    public static void PrintToConsole(this List<ProxyData> proxyList)
    {
        // Печать заголовка
        PrintHeader();
        // Печать таблицы
        PrintTable(proxyList);
    }

    private static void PrintHeader()
    {
        // Устанавливаем цвет шрифта
        Console.ForegroundColor = ConsoleColor.Green;
        // Вывод обводки таблицы
        Console.WriteLine(new string('-', ipWidth + portWidth + loactiontWidth + protocolWidth + anonimitylWidth +5));
        // Вывод заголовков столбцов
        Console.WriteLine($"{"IP".PadRight(ipWidth)}|" +
                          $"{"ПОРТ".PadRight(portWidth)}|" +
                          $"{"СТРАНА, ГОРОД".PadRight(loactiontWidth)}|" +
                          $"{"ТИП".PadRight(protocolWidth)}|" +
                          $"{"АНОНИМНОСТЬ".PadRight(anonimitylWidth)}");
        // Вывод обводки таблицы
        Console.WriteLine(new string('-', ipWidth + portWidth + loactiontWidth + protocolWidth + anonimitylWidth +5));
        // Сбрасываем цвет шрифта
        Console.ResetColor();
    }

    private static void PrintTable(List<ProxyData> proxyList)
    {
        // Устанавливаем цвет шрифта
      //  Console.ForegroundColor = ConsoleColor.White;
        // Печатаем данные
        foreach (var proxy in proxyList)
        {
            // Выводим в консоль
            Console.WriteLine($"{proxy.Ip.PadRight(ipWidth)}|" +
                              $"{proxy.Port.PadRight(portWidth)}|" +
                              $"{$"{proxy.Country}, {proxy.City}".PadRight(loactiontWidth)}|" +
                              $"{proxy.Protocol.PadRight(protocolWidth)}|" +
                              $"{proxy.Anonymity.PadRight(anonimitylWidth)}");
            
            // Вывод обводки таблицы
            Console.WriteLine(new string('-', ipWidth + portWidth + loactiontWidth + protocolWidth + anonimitylWidth +5));
        }
        // Скидываем цвет текста
        Console.ResetColor();
    }
}