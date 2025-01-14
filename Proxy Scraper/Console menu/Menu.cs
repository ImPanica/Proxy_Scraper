using Proxy_Scraper.Entities;
using Proxy_Scraper.Helper;

namespace Proxy_Scraper.Console_menu;

public class Menu
{
    public static void ShowMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nВыберите команду");
        Console.WriteLine("1 - Сохранить прокси в файл");
        Console.WriteLine("q - Выйти");
        Console.ResetColor();
    }

    public static async Task HandleUserInput(char input, List<ProxyData> proxyList = null)
    {
        // Обрабатываем выбор
        switch (input)
        {
            case '1':
                await Files.SaveToFile(proxyList); // сохранение в файл
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Прокси успешно сохранены");
                Console.ResetColor();
                break;
            case 'q':
                Environment.Exit(0); // выход+
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Указан не верный аргумент");
                break;
                
        }
    }
}