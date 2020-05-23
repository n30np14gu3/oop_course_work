using System;

namespace oop_server
{
    public static class ConsoleTools
    {
        public static void DisplayError(string message)
        {
            WriteColor(message, ConsoleColor.Red);
        }

        public static void DisplayLog(string message)
        {
            WriteColor($"[{DateTime.Now:HH:m:s tt zzz}]: {message}", ConsoleColor.Green);
        }

        public static void WriteColor(string message, ConsoleColor color)
        {
            ConsoleColor backupColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = backupColor;
        }
    }
}