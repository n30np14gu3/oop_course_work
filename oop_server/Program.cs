using System;
using oop_sdk.io;
using WebSocketSharp.Server;

namespace oop_server
{
    class Program
    {
        static void Main()
        {
            Console.Title = "OOP SERVER";

            try
            {
                Config<ServerSettings> settings = new Config<ServerSettings>("config.json");
                settings.Load();

                Console.Write("Load settings (yes / no)?: ");
                bool load = Console.ReadLine() == "yes";
                if (settings.Data == null || !load)
                {
                    settings.Data = new ServerSettings();

                    Console.Write("Server port: ");
                    int.TryParse(Console.ReadLine(), out int port);
                    if (port <= 0)
                        throw new Exception("Invalid port!");

                    Console.Write("Run over lan? (yes / no): ");
                    settings.Data.share_over_lan = Console.ReadLine() == "yes";
                    settings.Data.port = port;
                    settings.Save();
                }

                string url = $"ws://{(settings.Data.share_over_lan ? "0.0.0.0" : "127.0.0.1")}:{settings.Data.port}";
                WebSocketServer wss = new WebSocketServer(url);
                wss.AddWebSocketService<EngineServer>("/engine");
                url += "/engine";
                wss.Start();
                Console.WriteLine($"Server started on [{url}] Press any key to close server...");
                Console.ReadKey();
                wss.Stop();
            }
            catch (Exception ex)
            {
                ConsoleTools.DisplayError(ex.Message);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }
    }
}
